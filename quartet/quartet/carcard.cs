using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quartet
{
    public class carcard
    {
        public enum category { maxspeed, zerotosixty, hp, cc, cylinders, RPM }
        public string id { get; set; }
        public string name {  get; set; }
        public int maxspeed {  get; set; }
        public double zerotosixty { get; set; }
        public int hp { get; set; }
        public int cc { get; set; }
        public int cylinders { get; set; }
        public int RPM { get; set; }
        public carcard(string id, string name, int maxspeed, double zerotosixty, int hp, int cc, int cylinders, int RPM)
        {
            this.id = id.ToUpper();
            this.name = name;
            this.maxspeed = maxspeed;
            this.zerotosixty = zerotosixty;
            this.hp = hp;
            this.cc = cc;
            this.cylinders = cylinders;
            this.RPM = RPM;
        }
        public carcard compare(carcard other, category c)
        {
            if (other == null) return this;
            //maxspeed
            if (c == category.maxspeed) if (maxspeed > other.maxspeed) return this;
                else return other;
            //zerotosixty
            if (c == category.zerotosixty) if (zerotosixty < other.zerotosixty) return this;
                else return other;
            //hp
            if (c == category.hp) if (hp > other.hp) return this;
                else return other;
            //cc
            if (c == category.cc) if (cc > other.cc) return this;
                else return other;
            //cylinders
            if (c == category.cylinders) if (cylinders > other.cylinders) return this;
                else return other;
            //rpm
            if (c == category.RPM) if (RPM > other.RPM) return this; else return other;
                else return other;

        }
        public override string ToString()
        {
            return "-" + name + "- \nmaxspeed: " + maxspeed
                + "\nzerotosixty: " + zerotosixty
                + "\nhp: " + hp
                + "\ncc: " + cc
                + "\ncylinders: " + cylinders
                + "\nRPM: " + RPM
                + "\n";
        }
    }
}
