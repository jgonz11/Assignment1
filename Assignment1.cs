/************************
 *  Name: Jessica Gonzalez
 *  PID: 6178653
 *  Assignment1
 *************************/
using System.Windows.Forms;
using System.Drawing;
using System;
class MyForm : Form
{
    private string name = "Jessica Gonzalez";
    private string titleBar = "Assignment 1";
    private Panel firstPanel;
    private Panel secondPanel;
    TextBox textBox = new TextBox();

    public MyForm (string titleBar, string name)
    {
        this.Text = titleBar;
        this.name = name;
        
        addPanels();
        
    }
    public MyForm (string name)
    {
        this.Text = titleBar;
        this.name = name;
        
        addPanels();
    }

    public MyForm ()
    {
        this.Text = titleBar;
        
        addPanels();
    }

    private Panel getFirstPanel ()
    {
        Panel panel1 = new Panel();
        panel1.BackColor = Color.Aqua;
        panel1.Height = 100;
        panel1.Width = 1000;
        panel1.Dock = DockStyle.Bottom;

        Label label = new Label();
        label.Text = name;
        panel1.Controls.Add(label);

        return panel1;
    }

    private Panel getSecondPanel ()
    {
        Panel panel2 = new Panel();

        panel2.BackColor = Color.Aquamarine;
        panel2.Height = 700;
        panel2.Width = 1000;

        Label label = new Label();
        label.Text = "Comments";
        panel2.Controls.Add(label);
        label.Top = 300;
        label.Left = 300;
       
        
        panel2.Controls.Add(textBox);
        textBox.Top = 300;
        textBox.Left = 400;
        textBox.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
        textBox.Width = 250;

        return panel2;
    }

    private Button getButton ()
    {
        Button button = new Button();
        button.Top = 620;
        button.Left = 860;
        button.Width = 100;

        button.Text = "Submit";
        button.BackColor = Color.AliceBlue;

        button.Click += new EventHandler(button_Click);

        return button;
    }
    private void button_Click(object sender, EventArgs e)
    {
        MessageBox.Show(textBox.Text);
    }

    private void addPanels ()
    {
        this.Size = new Size(1000, 800);
        firstPanel = getFirstPanel();
        secondPanel = getSecondPanel();
        Button button = getButton();
   
        Controls.Add(firstPanel);
        Controls.Add(secondPanel);
        secondPanel.Controls.Add(button);
    }
}
class Assignment1
{
    static void Main(String[] args)
    {
        MyForm form;

        if (args.Length == 2)
        {
            form = new MyForm(args[0], args[1]);
        }
        else if (args.Length == 1)
        {
             form = new MyForm(args[0]);
        }
        else
        {
             form = new MyForm();
        }

        Application.Run(form);
    }
}
    
