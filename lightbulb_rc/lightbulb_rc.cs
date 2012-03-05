using System;
using System.Collections.Generic;
using System.IO;

class parameters
{
    protected StreamReader inf;
    protected StreamWriter outf;
    protected List<tempprops> properties;
    //Capacitance in Farads
    public double farads;
    //Voltage in V
    public double volts;
    //Charge in C
    public double charge;
    //Area in mm^2
    public double area;
    //Length in mm
    public double length;
    //Mass in kg
    public double mass;
    public const double MIN_HEAT = 0.0001;
    public const double INITIAL_TEMP = 300;
    public const double TIME_STEP = 0.0000001;
    public parameters(string[] args)
    {
        if (args.Length < 6)
            throw new Exception();
        //Commands: material properties.csv output.csv area length density farads volts
        //                   0              1          2    3      4       5      6
        inf = new StreamReader(args[0]);
        outf = new StreamWriter(args[1]);
        area = double.Parse(args[2]);
        length = double.Parse(args[3]);
        double density = double.Parse(args[4]);
        //Convert density from g/cm^3 to kg/mm^3 giving us mass in kg
        mass = density * area * length * 0.000001;
        farads = double.Parse(args[5]);
        volts = double.Parse(args[6]);
        charge = volts * farads;
        properties = new List<tempprops>();
        parseinf();
    }

    public void simulate()
    {
        double heat;
        double temp = INITIAL_TEMP;
        double time = 0.0;
        outf.WriteLine("Time (s),Temperature (K),Charge (C),Voltage (V),Current (A),Resistance (Ohm),Resistivity (uOhm*cm),Heat (J),Specific Heat (J/kg/K)");
        do
        {
            tempprops prop = getparams(temp);
//            Console.WriteLine(prop.ToString());
            double resistance = prop.resist * length / area * 0.00001;
            double current = volts / resistance;
            heat = current * volts;
            outf.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8}",
                time, temp, charge, volts, current, resistance, prop.resist, heat * TIME_STEP, prop.spheat);
            temp += heat * TIME_STEP / prop.spheat / mass;
            charge -= current * TIME_STEP;
            volts = charge / farads;
            time += TIME_STEP;
        } while (heat > MIN_HEAT && temp < 3600);
        outf.Flush();
    }

    public tempprops getparams(double temp)
    {
        int ind1, ind2;
        //Find the temperature in the list
        for (ind1 = 0; ind1 < properties.Count && properties[ind1].temp < temp; ind1++) ;
        //Find the indices which we interpolate with
        if (ind1 == properties.Count)
        {
            ind2 = ind1 - 1;
            ind1 -= 2;
        }
        else if (ind1 == 0)
        {
            ind2 = 1;
        }
        else if (ind1 == properties.Count - 1)
        {
            ind2 = ind1 - 1;
        }
        else
        {
            ind2 = ind1;
            ind1--;
        }
        tempprops prop = properties[ind1].interpolate(properties[ind2], temp);
        //No real point of the following
        //properties.Insert(ind2, prop);
        return prop;
    }

    private void parseinf()
    {
        int index = 0;
        while (!inf.EndOfStream)
        {
            tempprops temp;
            string[] line = inf.ReadLine().Split(',');
            temp.temp = double.Parse(line[0]);
            temp.resist = double.Parse(line[1]);
            temp.spheat = double.Parse(line[2]);
            properties.Insert(index, temp);
            index++;
        }
        //Interpolate the front of the list for specific heats
        if (properties[0].spheat == 0)
        {
            //Find the first non-zero element
            for (index = 0; index < properties.Count && properties[index].spheat == 0; index++) ;
            int first = index;
            //Find the second non-zero element
            for (index++; index < properties.Count && properties[index].spheat == 0; index++) ;
            int second = index;
            tempprops lhs = properties[first];
            tempprops rhs = properties[second];
            for (index = second - 1; index >= 0; index--)
            {
                tempprops buf = lhs.interpolate(rhs, properties[index].temp);
                if (properties[index].spheat != 0)
                    buf.spheat = properties[index].spheat;
                properties[index] = buf;
            }
        }
        //Interpolate the back of the specific heats
        if (properties[properties.Count - 1].spheat == 0)
        {
            //Find the last non-zero element
            for (index = properties.Count - 1; index > 0 && properties[index].spheat == 0; index--) ;
            int last = index;
            //Find the previous non-zero element
            for (index--; index > 0 && properties[index].spheat == 0; index--) ;
            int second = index;
            tempprops lhs = properties[second];
            tempprops rhs = properties[last];
            //Interpolate over all the zeros!
            for (index = second + 1; index < properties.Count; index++)
            {
                tempprops buf = lhs.interpolate(rhs, properties[index].temp);
                if(properties[index].spheat != 0)
                    buf.spheat = properties[index].spheat;
                properties[index] = buf;
            }
        }
        //Interpolate everything else
        for (index = 0; index < properties.Count; index++)
        {
            if (properties[index].spheat == 0)
            {
                int prvind, nextind;
                prvind = index - 1;
                //It's safe to assume we won't hit the end of the list because we already interpolated those values
                for (nextind = index + 1; properties[nextind].spheat == 0; nextind++) ;
                tempprops lhs = properties[prvind];
                tempprops rhs = properties[nextind];
                for (; index < nextind; index++)
                {
                    tempprops buf = lhs.interpolate(rhs, properties[index].temp);
                    if(properties[index].spheat != 0)
                        buf.spheat = properties[index].spheat;
                    properties[index] = buf;
                }
            }
        }
    }

    public struct tempprops : IComparable
    {
        //The temperature of the material
        public double temp;
        //The resistivity of the material
        public double resist;
        //The specific heat of the material
        public double spheat;

        public override string ToString()
        {
            string s = String.Format("{0} K  {1} uOhm*cm  {2} J/kg/K", temp, resist, spheat);
            return s;
        }

        public tempprops interpolate(tempprops bound, double temp)
        {
            tempprops t = new tempprops();
            double rinc = bound.resist - resist;
            double sinc = bound.spheat - spheat;
            rinc /= bound.temp - this.temp;
            sinc /= bound.temp - this.temp;
            t.resist = rinc * (temp - this.temp) + resist;
            t.spheat = sinc * (temp - this.temp) + spheat;
            t.temp = temp;
            return t;
        }

        public int CompareTo(object o)
        {
            if(o is int)
            {
                int t = (int)o;
                return ((int)temp).CompareTo(t);
            }
            else if (o is Int16)
            {
                Int16 t = (Int16)o;
                return ((Int16)temp).CompareTo(t);
            }

            else if (o is Int32)
            {
                Int32 t = (Int32)o;
                return ((Int32)temp).CompareTo(t);
            }

            else if (o is Int64)
            {
                Int64 t = (Int64)o;
                return ((Int64)temp).CompareTo(t);
            }
            else if (o is double)
            {
                double t = (double)o;
                return temp.CompareTo(t);
            }
            else if(o is Double)
            {
                Double t = (Double)o;
                return temp.CompareTo(t);
            }
            throw new InvalidCastException("Attempt to compare tempprops to unknown type");
        }
    }

}

class lightbulb_rc
{

    public lightbulb_rc(string[] args)
    {
        parameters props;
        try {
            props = new parameters(args);
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.StackTrace);
            throw e;
        }
        props.simulate();

    }


    static int Main(string[] args)
    {
        new lightbulb_rc(args);
        return 0;
    }
}
