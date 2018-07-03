using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LearningStreamsV3._0
{

    public partial class Form1 : Form
    {

        
        List<Card> cards = new List<Card>();
        enum BodyPart
        {
            Head,
            Shoulders,
            Knees,
            Toes
        }
        public Form1()
        {
            InitializeComponent();
            Suits suit = new Suits();
            suit.Hello.Split();
            MessageBox.Show(suit.Hello);
           
        }
        private void WritePartInfo(BodyPart part, StreamWriter writer)
        {
            if (part == BodyPart.Head)
                writer.WriteLine("głowa jest owłosiona");
            else if (part == BodyPart.Shoulders)
                writer.WriteLine("ramiona są szerokie");
            else if (part == BodyPart.Knees)
                writer.WriteLine("kolana są guzowate");
            else if (part == BodyPart.Toes)
                writer.WriteLine("palce są malutkie");
            else
                writer.WriteLine("nieokreślona część jest nieokreślona");
        }
        private void WritePartInfoBySwitch(BodyPart part, StreamWriter writer) // Switch is easier to write and makes code more readable.
        {
            switch (part)
            {
                case BodyPart.Head:
                    writer.WriteLine("głowa jest owłosiona");
                    break;
                case BodyPart.Shoulders:
                    writer.WriteLine("ramiona są szerokie");
                    break;
                case BodyPart.Knees:
                    writer.WriteLine("kolana są guzowate");
                    break;
                case BodyPart.Toes:
                    writer.WriteLine("palce są malutkie");
                    break;
                default:
                    writer.WriteLine("nieokreślona część jest nieokreślona");
                    break;
            }
        }
        public void WriteCard(string FileName) //writing cards name to .txt
        {
            using (StreamWriter writer = new StreamWriter(FileName))
            {
                for (int i = 0; i < cards.Count; i++)
                {
                    //writer.WriteLine(cards[i].Name);
                }
            }
        }

        
        
    }
}
