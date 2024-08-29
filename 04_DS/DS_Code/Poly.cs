using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ProgrammingBasics_DS
{
    internal class Term
    {
        string variableName = "X";
        public string VariableName
        {
            get { return variableName; }
            set
            {
                foreach (char c in value)
                    if (!filter.Contains(c.ToString()))
                        return;

                variableName = value;
            }
        }
        float co, exp;
        string filter = "";
        public Term(float co, float exp, string vName="X")
        {
            this.co = co;
            this.exp = exp;
            filter = "abcdefghijklmnopqrstuvwxyz" +
                    "abcdefghijklmnopqrstuvwxyz".ToUpper();
            this.VariableName=vName;
        }

        public float Co
        {
            get { return co; }
            set { co = value; }
        }
        public float Exp
        {
            get { return exp; }
            set { exp = value; }
        }
        public float Value(float X)
        {
            return (float)(co * Math.Pow(X, exp));
        }
        public override string ToString()
        {
            // Conditional ? trueReturn: falseReturn;
            // exp == 1    ? ""        : "^" + exp
            //example 5X^5
            if (exp == 0)
                return $"{co}";
            string nwCo = 
        (co == 1 || co == -1 ? 
        co.ToString().Replace("1", "") : 
        co.ToString());
            return $"{nwCo}{variableName}{(exp == 1 ? "" : "^" + exp)} ";
        }
        public bool Add2Me( Term t,bool OverrideName=false)
        {
            if(!OverrideName && variableName != t.variableName)
            {
                Console.WriteLine($"Error Adding {this} to {t}, wrong Names ::Term.Add2Me()");
                return false;
            }
            if (Exp != t.Exp)
            {
                Console.WriteLine($"Error Adding {this} to {t}, wrong power ::Term.Add2Me()");
                return false;
            }
            co += t.co;
            return true;
        }
    }
    internal class Poly
    {
        List<Term> list = new List<Term>();
        public void AddTerm(Term t)
        {
            list.Add(t);
            if (list.Count > 1)
                t.VariableName = list[0].VariableName;
        }

        public void AddTerm(float co, float exp)
        {
            AddTerm(new Term(co, exp));
        }
        public void AddTerm(float c)
        {
            AddTerm(new Term(c, 0));
        }
        public override string ToString()
        {
            string str = "";
            foreach (Term t in list)
                str += t+"+ ";
            if (str.Length == 0) return "";
            return str.Substring(0, str.Length - 2)
                .Replace("+ -", "-");
                
        }
        public string VariableName
        {
            set
            {
                foreach (Term t in list)
                    t.VariableName = value;
            }
            get
            {
                if (list.Count > 0) return list[0].VariableName;
                else return "X";
            }
        }
       public bool Add2Me(Poly p,bool OverrideName=false)
        {
            if(!OverrideName && this.VariableName!=p.VariableName)
            {
                Console.WriteLine($"Error Adding , wrong Names ::Poly.Add2Me()");
                return false;
            }
            Poly res = new Poly();
            int i = 0, j = 0;
            while (i < list.Count || j < p.list.Count)
            {
                if (list[i].Exp == p.list[j].Exp)
                {
                    res.AddTerm(new Term(list[i].Co, list[i].Exp, VariableName));
                    res.list[res.list.Count - 1].Add2Me(p.list[j]);
                    i++; j++;
                }
                else if (list[i].Exp > p.list[j].Exp)
                {
                    res.AddTerm(new Term(list[i].Co, list[i].Exp, VariableName));
                    i++;
                }
                else
                {
                    res.AddTerm(new Term(p.list[j].Co, p.list[j].Exp,p.VariableName));
                    j++;
                }
            }
            //this = res;
            this.list = res.list;
            return true;
        }
    }
    internal class TestPoly
    {
        public static void Main_OOP_Poly()
        {
            Poly p1 = new Poly(),
                p2 = new Poly();
            p1.AddTerm(new Term(1, 6,"XY"));//
            p1.AddTerm(5, 5);
            p1.AddTerm(4, 4);
            p1.AddTerm(-1, 1);
            p1.AddTerm(5);
            Console.WriteLine(p1);

            p2.AddTerm(1, 6);
            p2.AddTerm(5, 5);
            p2.AddTerm(4, 4);
            p2.AddTerm(-1, 1);
            p2.AddTerm(5);
            Console.WriteLine("P2 : default\n"+p2);
            p2.VariableName = "XY";
            p2.Add2Me(p1);
            Console.WriteLine("P2 : After :\n"+ p2);

            // p = p1 + p2;
        }
        static void Main_GenList()
        {
            List<int> list = new List<int>();
            list.AddRange(new int[] { 1, 3, 4, 5 });

        }
        static void Main_ArrayList()
        {
            ArrayList l = new ArrayList();
            l.Add(1);
            l.Add("Ali");
            l.Add(1.1);
            l.Add(DateTime.Now);
            l.Add(new Poly());
            foreach (object o in l)
                Console.WriteLine($"{o} is the element {l.IndexOf(o)} ");

            int i = (int)l[0];
            l.Add("Ali");
            l.Add(1.1);
            DateTime d = (DateTime)l[3];
            Poly p = (Poly)l[4];


            Console.ReadLine();
        }
    }
}
/* 
 * Educational Code
 * Dr. Amr Mausad @ 2024
 * http://amrmausad.com
 */

