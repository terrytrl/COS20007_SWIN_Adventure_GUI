using System;
using System.Windows.Forms;
using SwinAdventure;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        
        Player player = new Player("Yoda", "The green midget");
        Item blueprints = new Item(new string[] { "blueprints" }, "a blueprint", "This looks important.");
        Item LightSaber = new Item(new string[] { "lightSabre",}, "a Lightsabre", "this plasma looks pretty hot.");
        Bag bag = new Bag(new string[] { "bag"}, "a small rucksack", "a little small");
        Item C3PO = new Item(new string[] {"C3PO"}, "C3PO", "I relate with your human cyborg");

        Locations deathStar = new Locations(new string[] { "death star" }, "death star", "Is this a moon... oh wait.");
        Locations moon = new Locations(new string[] { "moon" }, "moon", "not the death star.");

        CommandProcessor commandProcess = new CommandProcessor();

        string[] commandProcessor;

        public Form1()
        {
            InitializeComponent();
            player.Inventory.PutItem(blueprints);
            player.Inventory.PutItem(LightSaber);
            player.Inventory.PutItem(bag);
            bag.Inventory.PutItem(C3PO);

            Path PathToDeathstar = new Path(new string[] {"north"}, deathStar.Name, deathStar.FullDescription, deathStar);
            Path KesselRun = new Path(new string[] {"north"}, moon.Name, moon.FullDescription, moon);

            deathStar.Paths.Add(KesselRun);
            deathStar.Inventory.PutItem(C3PO);
            player.Location = deathStar;

            textBox3.Text += "I do not grant you the rank of master...\r\n";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string code;
            string temporary = textBox4.Text;
            textBox4.Clear();
            commandProcessor = temporary.Split();
            code = commandProcess.Execute(player, commandProcessor) + "\r\n";
            textBox3.Text = code.Replace("\n", Environment.NewLine);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
