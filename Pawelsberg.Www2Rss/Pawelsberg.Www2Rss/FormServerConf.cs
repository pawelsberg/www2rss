namespace Pawelsberg.Www2Rss;

public partial class FormServerConfiguration : Form
{
    public UInt16 Port { get; private set; }

    public bool Localonly { get; private set; }

    public bool Result { get; private set; }

    public FormServerConfiguration(UInt16 port, bool localonly)
    {
        InitializeComponent();
        Port = port;
        Localonly = localonly;
        Result = false;
        textBoxPort.Text = $"{Port}";
        checkLocalOnly.Checked = Localonly;
    }
    private void buttonOk_Click(object sender, EventArgs e)
    {
        Result = true;
        Close();
    }
    private void buttonCancel_Click(object sender, EventArgs e)
    {
        Close();
    }
    private void textBoxPort_TextChanged(object sender, EventArgs e)
    {
        Port = Convert.ToUInt16(textBoxPort.Text);
    }
    private void checkLocalOnly_CheckedChanged(object sender, EventArgs e)
    {
        Localonly = checkLocalOnly.Checked;
    }
}