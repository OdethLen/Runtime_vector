using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Runtime_vector
{
    public partial class Form1 : Form
    {
        int vectorSize;
        int[] vector;
        int index;
       
        public Form1()
        {
            InitializeComponent();
            vectorSize = 0;
            vector = new int[vectorSize];
            index = 0;     
        }



        private void btnCreatevector_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtSize.Text == "")
                {
                    MessageBox.Show("You must enter a size");
                    return;
                }

                vectorSize = Convert.ToInt32(txtSize.Text);
                vector = new int[vectorSize];

                MessageBox.Show("Vector has been created" + " - Size: " + vectorSize);
            }
            catch (Exception)
            {

                MessageBox.Show("Wrong format, enter the correct format");
                return; 
            }
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text == "")
            {
                MessageBox.Show("You must enter a number");
                return;
                
            }

            if (vector == null || vectorSize == 0)
            {
                MessageBox.Show("Create the vector first");
                return;
            }

            if (index >= vectorSize)
            {
                MessageBox.Show("Vector is full");
                return;
            }

            int number = Convert.ToInt32(txtNumber.Text);
            vector[index] = number;
            index++;

            string vectorContent = "[";
            for (int i = 0; i < index; i++)
            {
                vectorContent += vector[i];
                if (i < index - 1) // Si no es el último elemento, añadir coma
                {
                    vectorContent += ", ";
                }
            }
            vectorContent += "]";

            
            MessageBox.Show("Number " + number + " added! Current vector: " + vectorContent);
        }
    }
}
