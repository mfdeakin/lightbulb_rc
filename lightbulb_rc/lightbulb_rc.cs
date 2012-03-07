using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace lightbulb_rc
{
    public partial class lightbulb_rc : Form
    {
        public lightbulb_rc()
        {
            InitializeComponent();
        }

        [STAThread]
        public static void Main(string[] args)
        {
            try
            {
                simulator sim = new simulator(args);
                sim.simulate();
            }
            catch (FileLoadException e)
            {
                Console.Error.Write(e.Message);
            }
            catch (Exception e)
            {
                //System.Threading.Thread t = System.Threading.Thread.CurrentThread;
                //t.SetApartmentState(System.Threading.ApartmentState.STA);
                lightbulb_rc control = new lightbulb_rc();
                Application.Run(control);
            }
        }

        private void lightbulb_rc_Load(object sender, EventArgs e)
        {
            sim = new simulator();
            initchildren();
            inputtoggler = new d_toggleinput(toggleinput);
            changetext = new d_settext(settext);
        }

        void initchildren()
        {
            txt_infname.Text = "tungsten.csv";
            txt_outfname.Text = "tungsten.out.csv";
            txt_outfname.Focus();
            txt_infname.Focus();
            txt_area.Text = "0.0016619025";
            txt_length.Text = "5";
            txt_density.Text = "0.000001925";
            txt_cap.Text = "1";
            txt_initvolt.Text = "3";
            txt_inittemp.Text = "300";
            txt_maxtemp.Text = "3600";
            txt_minpower.Text = "0.01";
            txt_timestep.Text = "0.1";
            ValidateChildren();
        }

        private void btn_simulate_Click(object sender, EventArgs e)
        {
            if (bck_sim.IsBusy)
            {
                bck_sim.CancelAsync();
            }
            else
            {
                bck_sim.RunWorkerAsync();
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            of_dialog.ShowDialog();
            txt_infname.Text = of_dialog.FileName;
            ValidateChildren();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            sf_dialog.ShowDialog();
            txt_outfname.Text = sf_dialog.FileName;
            ValidateChildren();
        }

        private void bck_sim_DoWork(object sender, DoWorkEventArgs e)
        {
            btn_simulate.Invoke(changetext, new object[] { btn_simulate, "Stop Simulation" });
            txt_infname.Invoke(inputtoggler, new object[] { txt_infname });
            txt_outfname.Invoke(inputtoggler, new object[] { txt_outfname });
            txt_area.Invoke(inputtoggler, new object[] { txt_area});
            txt_length.Invoke(inputtoggler, new object[] { txt_length});
            txt_density.Invoke(inputtoggler, new object[] { txt_density});
            txt_cap.Invoke(inputtoggler, new object[] { txt_cap });
            txt_initvolt.Invoke(inputtoggler, new object[] { txt_initvolt});
            txt_inittemp.Invoke(inputtoggler, new object[] { txt_inittemp});
            txt_maxtemp.Invoke(inputtoggler, new object[] { txt_maxtemp});
            txt_minpower.Invoke(inputtoggler, new object[] { txt_minpower});
            txt_timestep.Invoke(inputtoggler, new object[] { txt_timestep});
            BackgroundWorker worker = (BackgroundWorker)sender;
            bool cont = true;
            sim.siminit();
            while (!worker.CancellationPending && cont)
            {
                cont = sim.simstep();
            }
            if (worker.CancellationPending)
                e.Cancel = true;
        }

        private void bck_sim_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btn_simulate.Invoke(changetext, new object[] { btn_simulate, "Simulate" });
            txt_infname.Invoke(inputtoggler, new object[] { txt_infname });
            txt_outfname.Invoke(inputtoggler, new object[] { txt_outfname });
            txt_area.Invoke(inputtoggler, new object[] { txt_area });
            txt_length.Invoke(inputtoggler, new object[] { txt_length });
            txt_density.Invoke(inputtoggler, new object[] { txt_density });
            txt_cap.Invoke(inputtoggler, new object[] { txt_cap });
            txt_initvolt.Invoke(inputtoggler, new object[] { txt_initvolt });
            txt_inittemp.Invoke(inputtoggler, new object[] { txt_inittemp });
            txt_maxtemp.Invoke(inputtoggler, new object[] { txt_maxtemp });
            txt_minpower.Invoke(inputtoggler, new object[] { txt_minpower });
            txt_timestep.Invoke(inputtoggler, new object[] { txt_timestep });
            sim.simend();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool txt_fpvalidate(object sender)
        {
            TextBox txt = (TextBox)sender;
            double tmp;
            if (double.TryParse(txt.Text, out tmp))
            {
                txt.BackColor = Color.White;
                return true;
            }
            else
            {
                txt.BackColor = Color.Pink;
                return false;
            }
        }

        private void txt_infval(object sender, CancelEventArgs e)
        {
            if (File.Exists(txt_infname.Text))
            {
                txt_infname.BackColor = Color.White;
                sim.inname = txt_infname.Text;
            }
            else
            {
                txt_infname.BackColor = Color.Pink;
            }
        }

        private void txt_outfval(object sender, CancelEventArgs e)
        {
            if (File.Exists(txt_outfname.Text))
                txt_outfname.BackColor = Color.Yellow;
            else
                txt_outfname.BackColor = Color.White;
            sim.outname = txt_outfname.Text;
        }

        private void txt_areaval(object sender, CancelEventArgs e)
        {
            if (txt_fpvalidate(txt_area))
                sim.area = double.Parse(txt_area.Text);
        }

        private void txt_lengthval(object sender, CancelEventArgs e)
        {
            if (txt_fpvalidate(txt_length))
                sim.length= double.Parse(txt_length.Text);
        }

        private void txt_densityval(object sender, CancelEventArgs e)
        {
            if (txt_fpvalidate(txt_density))
                sim.density = double.Parse(txt_density.Text);
        }

        private void txt_capval(object sender, CancelEventArgs e)
        {
            if (txt_fpvalidate(txt_cap))
                sim.farads = double.Parse(txt_cap.Text);
        }

        private void txt_initvoltval(object sender, CancelEventArgs e)
        {
            if (txt_fpvalidate(txt_initvolt))
                sim.volts = double.Parse(txt_initvolt.Text);
        }

        private void txt_inittempval(object sender, CancelEventArgs e)
        {
            if (txt_fpvalidate(txt_inittemp))
                sim.INITIAL_TEMP = double.Parse(txt_inittemp.Text);
        }

        private void txt_maxtempval(object sender, CancelEventArgs e)
        {
            if (txt_fpvalidate(txt_maxtemp))
                sim.MAX_TEMP = double.Parse(txt_maxtemp.Text);
        }

        private void txt_minpowerval(object sender, CancelEventArgs e)
        {
            if (txt_fpvalidate(txt_minpower))
                sim.MIN_HEAT = double.Parse(txt_minpower.Text);
        }

        private void txt_timestepval(object sender, CancelEventArgs e)
        {
            if (txt_fpvalidate(txt_timestep))
                sim.TIME_STEP = double.Parse(txt_timestep.Text) / 1000;
        }

        private void toggleinput(TextBox t)
        {
            t.Enabled = !t.Enabled;
        }

        private void settext(Button b, string text)
        {
            b.Text = text;
        }

        private simulator sim;
        private delegate void d_toggleinput(TextBox t);
        private delegate void d_settext(Button b, string text);
        private d_toggleinput inputtoggler;
        private d_settext changetext;
    }

    class simulator
    {
        protected StreamReader inf;
        public string inname;
        protected StreamWriter outf;
        public string outname;
        protected List<tempprops> properties;
        //Capacitance in Farads
        public double farads
        {
            get { return capacitance; }
            set
            {
                capacitance = value;
                charge = volts * capacitance;
            }
        }
        //Voltage in V
        public double volts
        {
            get { return voltage; }
            set
            {
                voltage = value;
                charge = voltage * farads;
            }
        }

        private double capacitance;
        private double voltage;
        //Charge in C
        public double charge;
        //Area in mm^2
        public double area;
        //Length in mm
        public double length;
        //Mass in kg
        public double mass;
        //Density in kg/mm^3
        public double density
        {
            get { return mass / area / length; }
            set { mass = value * area * length; }
        }
        //The current temperature
        public double temp;
        //Time in s
        public double time;

        public double MIN_HEAT = 0.0001;
        public double INITIAL_TEMP = 300;
        public double TIME_STEP = 0.000001;
        public double MAX_TEMP = 3600;

        public simulator()
        {
        }

        public simulator(string[] args)
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
            temp = INITIAL_TEMP;
            time = 0.0;
            outf.WriteLine("Time (s),Temperature (K),Charge (C),Voltage (V),Current (A),Resistance (Ohm),Resistivity (uOhm*cm),Heat (J),Specific Heat (J/kg/K)");
            do
            {
                tempprops prop = getparams(temp);
                double resistance = prop.resist * length / area * 0.00001;
                double current = volts / resistance;
                heat = current * volts;
                outf.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8}",
                    time, temp, charge, volts, current, resistance, prop.resist, heat * TIME_STEP, prop.spheat);
                temp += heat * TIME_STEP / prop.spheat / mass;
                charge -= current * TIME_STEP;
                volts = charge / farads;
                time += TIME_STEP;
            } while (heat > MIN_HEAT && temp < MAX_TEMP);
            outf.Close();
        }

        //Sets up the simulation
        public void siminit()
        {
            time = 0;
            temp = INITIAL_TEMP;
            inf = new StreamReader(inname);
            outf = new StreamWriter(outname);
            properties = new List<tempprops>();
            parseinf();
            outf.WriteLine("Time (s),Temperature (K),Charge (C),Voltage (V),Current (A),Resistance (Ohm),Resistivity (uOhm*cm),Heat (J),Specific Heat (J/kg/K)");
        }

        //Returns false when done simulating
        public bool simstep()
        {
            tempprops prop = getparams(temp);
            double resistance = prop.resist * length / area * 0.001;
            double current = volts / resistance;
            double heat = current * volts;
            outf.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7},{8}",
                time, temp, charge, volts, current, resistance, prop.resist, heat * TIME_STEP, prop.spheat);
            temp += heat * TIME_STEP / prop.spheat / mass;
            charge -= current * TIME_STEP;
            volts = charge / farads;
            time += TIME_STEP;
            return (heat > MIN_HEAT) && (temp < MAX_TEMP);
        }

        public void simend()
        {
            outf.Close();
            inf.Close();
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
                    if (properties[index].spheat != 0)
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
                        if (properties[index].spheat != 0)
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
                if (o is int)
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
                else if (o is Double)
                {
                    Double t = (Double)o;
                    return temp.CompareTo(t);
                }
                throw new InvalidCastException("Attempt to compare tempprops to unknown type");
            }
        }
    }
}
