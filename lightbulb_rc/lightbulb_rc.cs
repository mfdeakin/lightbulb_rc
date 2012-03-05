using System;
using System.Collections.Generic;
using System.IO;

class parameters
{
    protected StreamReader inf;
    protected List<tempprops> properties;
    public double farads;
    public double volts;
    public double area;
    public double length;
    public double mass;

    public parameters(string[] args)
    {
        if (args.Length < 6)
            throw new Exception();
        //Commands: material properties.csv output.csv area length density farads volts
        //                   0              1          2    3      4       5      6
        inf = new StreamReader(args[0]);
        area = double.Parse(args[2]);
        length = double.Parse(args[3]);
        double density = double.Parse(args[4]);
        mass = density * area * length;
        farads = double.Parse(args[5]);
        volts = double.Parse(args[6]);
        properties = new List<tempprops>();
        parseinf();
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
            double increment = properties[second].spheat - properties[first].spheat;
            increment /= (properties[second].temp - properties[first].temp);
            for (index = first - 1; index >= 0; index--)
            {
                double current = properties[index].temp - properties[first].temp;
                current = current * increment + properties[first].spheat;
                tempprops newprop = properties[index];
                newprop.spheat = current;
                properties[index] = newprop;
            }
        }
        if (properties[properties.Count - 1].spheat == 0)
        {
            for (index = properties.Count - 1; index > 0 && properties[index].spheat == 0; index--) ;
            int last = index;
            for (index--; index > 0 && properties[index].spheat == 0; index--) ;
            int second = index;
            double increment = properties[last].spheat - properties[second].spheat;
            increment /= (double)(properties[last].temp - properties[second].temp);
            for (index = second + 1; index < properties.Count; index++)
            {
                double current = properties[index].temp - properties[second].temp;
                current = current * increment + properties[second].spheat;
                tempprops newprop = properties[index];
                newprop.spheat = current;
                properties[index] = newprop;
            }
        }
        foreach (tempprops prop in properties)
            System.Console.WriteLine("{0:f10} {1:f10} {2:f10}", prop.temp, prop.resist, prop.spheat);
    }

    protected struct tempprops
    {
        //The temperature of the material
        public double temp;
        //The resistivity of the material
        public double resist;
        //The specific heat of the material
        public double spheat;
    }

}

class lightbulb_rc
{

    public lightbulb_rc(string[] args)
    {
        parameters opts;
        try {
            opts = new parameters(args);
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.StackTrace);
            throw e;
        }


    }

    protected FileStream outf;

    static int Main(string[] args)
    {
        new lightbulb_rc(args);
        return 0;
    }
}
