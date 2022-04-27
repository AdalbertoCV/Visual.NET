namespace examen2;

public partial class Form1 : Form
{
    public Label lblMoneda;
    public Label lblMonto;
    public ComboBox cmbMoneda;
    public TextBox txtMonto;
    public Label lblConversiones;

    public Button btnCalcular;

    public Label lblC1;
    public Label lblC2;
    public Label lblC3;
    public Label lblC4;
    public TextBox txtC1;
    public TextBox txtC2;
    public TextBox txtC3;
    public TextBox txtC4;

    public Form1()
    {
        lblMoneda = new Label();
        lblMonto = new Label();
        lblConversiones = new Label();
        cmbMoneda = new ComboBox();
        btnCalcular = new Button();
        lblC1 = new Label();
        lblC2 = new Label();
        lblC3 = new Label();
        lblC4 = new Label();
        txtMonto = new TextBox();
        txtC1 = new TextBox();
        txtC2 = new TextBox();
        txtC3 = new TextBox();
        txtC4 = new TextBox();
        InitializeComponent();
        InicializarComponentes();
    }

    private void InicializarComponentes()
    {
        this.Size = new Size(400,420);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.Text = "Conversor de Monedas";
        lblMoneda.Text = "Moneda";
        lblMoneda.AutoSize = true;
        lblMoneda.Location = new Point(10,10);
        this.Controls.Add(lblMoneda);
        lblMonto.Text = "Monto";
        lblMonto.AutoSize = true;
        lblMonto.Location = new Point(200,10);
        this.Controls.Add(lblMonto);
        cmbMoneda.Size = new Size(180,20);
        cmbMoneda.Location = new Point(10,30);
        cmbMoneda.Items.Add("MXN");
        cmbMoneda.Items.Add("USD");
        cmbMoneda.Items.Add("CAD");
        cmbMoneda.Items.Add("EUR");
        cmbMoneda.Items.Add("JPY");
        this.Controls.Add(cmbMoneda);
        txtMonto.Size = new Size (150,20);
        txtMonto.Location = new Point (200,30);
        this.Controls.Add(txtMonto);
        btnCalcular.Text = "Calcular";
        btnCalcular.AutoSize = true;
        btnCalcular.Location = new Point(270,70);
        btnCalcular.Click += btnCalcular_Click;
        this.Controls.Add(btnCalcular);
        lblConversiones.Text = "Conversiones";
        lblConversiones.AutoSize = true;
        lblConversiones.Location = new Point(10,110);
        this.Controls.Add(lblConversiones);
        lblC1.AutoSize = true;
        lblC2.AutoSize = true;
        lblC3.AutoSize = true;
        lblC4.AutoSize = true;
        lblC1.Visible = false;
        lblC2.Visible = false;
        lblC3.Visible = false;
        lblC4.Visible = false;
        lblC1.Location = new Point(10,150);
        lblC2.Location = new Point(10,200);
        lblC3.Location = new Point(10,250);
        lblC4.Location = new Point(10,300);
        this.Controls.Add(lblC1);
        this.Controls.Add(lblC2);
        this.Controls.Add(lblC3);
        this.Controls.Add(lblC4);
        txtC1.Size = new Size(150,20);
        txtC1.Location = new Point(200,150);
        txtC2.Size = new Size(150,20);
        txtC2.Location = new Point(200,200);
        txtC3.Size = new Size(150,20);
        txtC3.Location = new Point(200,250);
        txtC4.Size = new Size(150,20);
        txtC4.Location = new Point(200,300);
        txtC1.Visible = false;
        txtC2.Visible = false;
        txtC3.Visible = false;
        txtC4.Visible = false;
        this.Controls.Add(txtC1);
        this.Controls.Add(txtC2);
        this.Controls.Add(txtC3);
        this.Controls.Add(txtC4);
    }

    private void btnCalcular_Click(object? sender, EventArgs e){
        double monto =0.0;
        double.TryParse(txtMonto.Text,out monto);              
        if (cmbMoneda.SelectedItem!=null && txtMonto.Text!=""){
        txtC1.Visible = false;
        txtC2.Visible = false;
        txtC3.Visible = false;
        txtC4.Visible = false;
        lblC1.Visible = false;
        lblC2.Visible = false;
        lblC3.Visible = false;
        lblC4.Visible = false;
        Form2 form = new Form2(cmbMoneda.SelectedItem.ToString());
        if(form.ShowDialog() == DialogResult.OK){
            if (cmbMoneda.SelectedItem.ToString() == "MXN"){
                if (form.cbUS.Checked == true){
                    lblC1.Text = "USD";
                    txtC1.Text = "$" + (monto*0.05);
                    txtC1.Visible = true;
                    lblC1.Visible = true;
                }
                if (form.cbCAD.Checked == true){
                    lblC2.Text = "CAD";
                    txtC2.Text = "$"+ (monto*0.06);
                    txtC2.Visible = true;
                    lblC2.Visible = true;
                }
                if (form.cbEUR.Checked == true){
                    lblC3.Text = "EUR";
                    txtC3.Text = "€"+ (monto*0.04);
                    txtC3.Visible = true;
                    lblC3.Visible = true;
                }
                if (form.cbYN.Checked == true){
                    lblC4.Text = "JPY";
                    txtC4.Text = "¥"+ (monto*5.32);
                    txtC4.Visible = true;
                    lblC4.Visible = true;
                }
                }else{
                    if (cmbMoneda.SelectedItem.ToString() == "USD"){
                        if (form.cbMX.Checked == true){
                            lblC1.Text = "MXN";
                            txtC1.Text = "$" + (monto*21.23);
                            txtC1.Visible = true;
                            lblC1.Visible = true;
                        }
                        if (form.cbCAD.Checked == true){
                            lblC2.Text = "CAD";
                            txtC2.Text = "$"+ (monto*1.28);
                            txtC2.Visible = true;
                            lblC2.Visible = true;
                        }
                        if (form.cbEUR.Checked == true){
                            lblC3.Text = "EUR";
                            txtC3.Text = "€"+ (monto*0.89);
                            txtC3.Visible = true;
                            lblC3.Visible = true;
                        }
                        if (form.cbYN.Checked == true){
                            lblC4.Text = "JPY";
                            txtC4.Text = "¥"+ (monto*113.05);
                            txtC4.Visible = true;
                            lblC4.Visible = true;
                        }
                        }else{
                            if(cmbMoneda.SelectedItem.ToString() == "CAD"){
                                if (form.cbUS.Checked == true){
                                    lblC1.Text = "USD";
                                    txtC1.Text = "$" + (monto*0.78);
                                    txtC1.Visible = true;
                                    lblC1.Visible = true;
                                }
                                if (form.cbMX.Checked == true){
                                    lblC2.Text = "MXN";
                                    txtC2.Text = "$" + (monto*16.55);
                                    txtC2.Visible = true;
                                    lblC2.Visible = true;
                                }
                                if (form.cbEUR.Checked == true){
                                    lblC3.Text = "EUR";
                                    txtC3.Text = "€"+ (monto*0.69);
                                    txtC3.Visible = true;
                                    lblC3.Visible = true;
                                }
                                if (form.cbYN.Checked == true){
                                    lblC4.Text = "JPY";
                                    txtC4.Text = "¥"+ (monto*88.12);
                                    txtC4.Visible = true;
                                    lblC4.Visible = true;
                                }
                            }else{
                                if (cmbMoneda.SelectedItem.ToString() == "EUR"){
                                    if (form.cbUS.Checked == true){
                                        lblC1.Text = "USD";
                                        txtC1.Text = "$" + (monto*1.13);
                                        txtC1.Visible = true;
                                        lblC1.Visible = true;
                                    }
                                    if (form.cbMX.Checked == true){
                                        lblC3.Text = "MXN";
                                        txtC3.Text = "$" + (monto*23.96);
                                        txtC3.Visible = true;
                                        lblC3.Visible = true;
                                    }
                                    if (form.cbCAD.Checked == true){
                                        lblC2.Text = "CAD";
                                        txtC2.Text = "$"+ (monto*1.45);
                                        txtC2.Visible = true;
                                        lblC2.Visible = true;
                                    }
                                    if (form.cbYN.Checked == true){
                                        lblC4.Text = "JPY";
                                        txtC4.Text = "¥"+ (monto*127.56);
                                        txtC4.Visible = true;
                                        lblC4.Visible = true;
                                    }
                                }else{
                                    if(cmbMoneda.SelectedItem.ToString() == "JPY"){
                                        if (form.cbUS.Checked == true){
                                            lblC1.Text = "USD";
                                            txtC1.Text = "$" + (monto*0.0088);
                                            txtC1.Visible = true;
                                            lblC1.Visible = true;
                                        }
                                        if (form.cbMX.Checked == true){
                                            lblC4.Text = "MXN";
                                            txtC4.Text = "$" + (monto*0.1878);
                                            txtC4.Visible = true;
                                            lblC4.Visible = true;
                                        }
                                        if (form.cbCAD.Checked == true){
                                            lblC2.Text = "CAD";
                                            txtC2.Text = "$"+ (monto*0.0113);
                                            txtC2.Visible = true;
                                            lblC2.Visible = true;
                                        }
                                        if (form.cbEUR.Checked == true){
                                            lblC3.Text = "EUR";
                                            txtC3.Text = "€"+ (monto*0.0078);
                                            txtC3.Visible = true;
                                            lblC3.Visible = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
        } 
    }
}
