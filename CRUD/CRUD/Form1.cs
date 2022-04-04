namespace CRUD;

public partial class Form1 : Form
{
    private CervezaContext bd;
    private DataGridView gdCervezas;
    private Button btnAgregar;
    private Button btnEditar;
    private Button btnEliminar;

    public Form1()
    {
        bd = new CervezaContext();
        gdCervezas = new DataGridView();
        btnAgregar = new Button();
        btnEditar = new Button();
        btnEliminar = new Button();
        InitializeComponent();
        inicializarComponentes();
    }

    private void inicializarComponentes()
    {
        gdCervezas.DataSource = bd.cervezas.ToList();
        this.Size = new Size(650,350);
        gdCervezas.Size = new Size(500,280);
        gdCervezas.Location = new Point(15,15);
        btnAgregar.AutoSize = true;
        btnEditar.AutoSize = true;
        btnEliminar.AutoSize = true;
        btnAgregar.Text = "Agregar";
        btnEditar.Text = "Editar";
        btnEliminar.Text = "Eliminar";
        btnAgregar.Location = new Point(530,15);
        btnEditar.Location = new Point(530,150);
        btnEliminar.Location = new Point(530,270);
        btnAgregar.Click+= btnAgregar_click;
        this.Controls.Add(gdCervezas);
        this.Controls.Add(btnAgregar);
        this.Controls.Add(btnEditar);
        this.Controls.Add(btnEliminar);
    }

    private void btnAgregar_click(object? sender, EventArgs e){
        cerveza nueva = new cerveza(){
            Nombre = "Corona",
            Estilo = "Pilsner",
            Alcohol = 4.5

        };
        bd.Add(nueva);
        bd.SaveChanges();
        gdCervezas.DataSource = bd.cervezas.ToList();
    }
}
