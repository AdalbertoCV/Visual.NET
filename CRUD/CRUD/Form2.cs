namespace CRUD;

public partial class Form2 : Form
{
    private TableLayoutPanel tlCampos;
    private Label lblNombre;
    private Label lblEstilo;
    private Label lblAlcohol;
    private TextBox txtNombre;
    private TextBox txtEstilo;
    private TextBox txtAlcohol;
    private Button btnGuardar;
    private Button btnCancelar;
    public cerveza cerveza;

    public Form2()
    {
        tlCampos = new TableLayoutPanel();
        lblNombre = new Label();
        lblEstilo = new Label();
        lblAlcohol= new Label();
        txtNombre = new TextBox();
        txtEstilo =new TextBox();
        txtAlcohol =new TextBox();
        btnGuardar = new Button();
        btnCancelar= new Button();
        cerveza = new cerveza();
        InitializeComponent();
        inicializarComponentes();
    }

    public Form2(cerveza c):this(){
        this.cerveza = c;
        txtNombre.Text = cerveza.Nombre;
        txtEstilo.Text = cerveza.Estilo;
        txtAlcohol.Text = cerveza.Alcohol.ToString();
    }

    private void inicializarComponentes()
    {
        this.Size = new Size(300,300);
        lblNombre.AutoSize = true;
        lblEstilo.AutoSize = true;
        lblAlcohol.AutoSize = true;
        txtNombre .Size = new Size(150,23);
        txtEstilo.Size = new Size(150,23);
        txtAlcohol.Size = new Size(100,23);
        btnGuardar.AutoSize = true;
        btnCancelar.AutoSize = true;
        lblNombre.Text="Nombre";
        lblEstilo.Text="Estilo";
        lblAlcohol.Text="Alcohol";
        btnGuardar.Text = "Guardar";
        btnCancelar.Text = "Cancelar";
        btnCancelar.Click+= new EventHandler(btnCancelar_click);
        btnGuardar.Click+= new EventHandler(btnGuardar_click);
        tlCampos.AutoSize = true;
        tlCampos.ColumnCount = 1;
        tlCampos.RowCount = 6;
        tlCampos.Controls.Add(lblNombre);
        tlCampos.Controls.Add(txtNombre);
        tlCampos.Controls.Add(lblEstilo);
        tlCampos.Controls.Add(txtEstilo);
        tlCampos.Controls.Add(lblAlcohol);
        tlCampos.Controls.Add(txtAlcohol);
        tlCampos.Location = new Point(15,15);
        btnGuardar.Location = new Point(200,200);
        btnCancelar.Location = new Point(15,200);
        this.Controls.Add(tlCampos);
        this.Controls.Add(btnCancelar);
        this.Controls.Add(btnGuardar);

    }

    private void btnGuardar_click(object? sender, EventArgs e){
        cerveza.Nombre = txtNombre.Text;
        cerveza.Estilo = txtEstilo.Text;
        cerveza.Alcohol = Double.Parse(txtAlcohol.Text);
        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void btnCancelar_click(object? sender, EventArgs e){
        
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}