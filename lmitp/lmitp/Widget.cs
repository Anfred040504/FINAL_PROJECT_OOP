using System.Windows.Forms;
using System;

namespace lmitp.Components
{
    public partial class UserControl1 : UserControl
    {
        // Define events to notify when a selection is made
        public event EventHandler<DataSelectedEventArgs> DataSelected;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            // Raise the DataSelected event with the selected data
            DataSelected?.Invoke(this, new DataSelectedEventArgs(Product, Name001, Prize001));
        }

        // Properties for the data shown in the UserControl
        public string Product { get; set; }
        public string Name001 { get; set; }
        public string Prize001 { get; set; }
    }

    // Custom EventArgs class to hold the selected data
    public class DataSelectedEventArgs : EventArgs
    {
        public string Product { get; }
        public string Name001 { get; }
        public string Prize001 { get; }

        public DataSelectedEventArgs(string product, string name, string prize)
        {
            Product = product;
            Name001 = name;
            Prize001 = prize;
        }
    }
}
