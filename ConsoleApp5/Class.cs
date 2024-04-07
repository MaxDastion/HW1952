using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
	public abstract class AbstractPerson
	{
		public abstract string Name { get; set; }
		public abstract int Number { get; set; }
		public abstract void Say(string wordl);
	}

	public class X : AbstractPerson
	{
		public override string Name { get; set; }
		public override int Number { get; set; }
		public override void Say(string wordl)
		{
			Console.WriteLine(wordl);
		}

	}
	public class Nick : X
	{
        public override string Name { get => base.Name += " Boss"; 
			set  {
				if (value == " ")
				{
					value = "Bob";
				}
				base.Name = value;
			}
		}
        public override int Number { get => base.Number% 8;
			set
			{
				if (value == null)
				{
					Random random = new Random();
					random.Next();
				}
				base.Number = value;
			} 
		}
        public override void Say(string wordl)
        {
            base.Say(wordl); Console.WriteLine($"My name {Name} and my number {Number}");
        }

    }
	public class Start
	{
		public Start() { 
			Nick nick = new Nick() {Name = " ", Number = 9 };
			nick.Say("Hi");
		}
	}

}
