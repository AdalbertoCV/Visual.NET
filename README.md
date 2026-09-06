# Programación Visual — .NET / C#

Repositorio del curso de **Programación Visual .NET** (Ingeniería de Software, Universidad Autónoma de Zacatecas, 2022). Cubre la progresión completa del ecosistema .NET: de aplicaciones de consola con POO, a **Windows Forms**, a **ASP.NET Core MVC** con Entity Framework Core, migraciones e **ASP.NET Identity**.

---

## Proyectos

### Aplicaciones web — ASP.NET Core MVC

| Proyecto | Descripción |
|---|---|
| **`Examen3`** *(el más completo)* | Sistema de gestión de un menú de restaurante. Tres controladores CRUD (`Platillos`, `Bebidas`, `Postres`) sobre Entity Framework Core, con **autenticación y registro de usuarios vía ASP.NET Identity**, scaffolding de vistas Razor y migraciones versionadas. |
| **`CRUDWEB`** | Catálogo de cervezas y estilos. CRUD completo con relación entre entidades (`Cervezas` ↔ `Estilos`), `ApplicationDbContext` con EF Core, Identity integrado y vistas Razor generadas por scaffolding. |

Ambos usan **SQL Server LocalDB** con `Trusted_Connection`, migraciones de EF Core y el sistema de áreas de Identity.

### Aplicaciones de escritorio — Windows Forms

| Proyecto | Descripción |
|---|---|
| **`CRUD`** | CRUD de escritorio sobre una base de datos de cervezas. Combina WinForms con **Entity Framework Core y migraciones** (`cervezaContext`), demostrando que el ORM es independiente de la capa de presentación. |
| **`Examen2`** | Aplicación multi-formulario con navegación entre ventanas y paso de datos entre ellas. |
| **`Calculadora`** | Calculadora de escritorio: manejo de eventos, controles y validación de entrada. |
| **`Tarea3`** | Introducción a WinForms: controles básicos y ciclo de vida del formulario. |

### Aplicaciones de consola — POO en C#

| Proyecto | Descripción |
|---|---|
| **`Tarea2`** | Sistema de videoclub con un modelo de dominio real: `Pelicula`, `Estante`, `Venta`, `ControlVentas`, más menús de navegación (`MenuPeliculas`, `MenuVentas`). Ejercicio de separación entre modelo, lógica de negocio y presentación. |
| **`Examen1`** | Juego por consola modelado con clases (`Juego`, `Jugada`, `MenuJuego`), aplicando encapsulamiento y responsabilidad única. |

---

## Estructura del repositorio

```
.
├── Examen3/            # ASP.NET Core MVC — menú de restaurante (Platillos, Bebidas, Postres) + Identity
├── CRUDWEB/            # ASP.NET Core MVC — catálogo de cervezas y estilos + Identity
├── CRUD/               # Windows Forms + EF Core con migraciones
├── Examen2/            # Windows Forms multi-formulario
├── Calculadora/        # Windows Forms — calculadora
├── Tarea3/             # Windows Forms — introducción
├── Tarea2/             # Consola — sistema de videoclub (POO)
└── Examen1/            # Consola — juego modelado con clases
```

---

## Conceptos aplicados

- **Entity Framework Core** — `DbContext`, mapeo de entidades, relaciones y **migraciones** versionadas.
- **ASP.NET Core MVC** — controladores, vistas Razor, scaffolding, ruteo y `_Layout`.
- **ASP.NET Identity** — registro, inicio de sesión, confirmación de cuenta y áreas protegidas.
- **Windows Forms** — diseñador de formularios, eventos, controles y navegación entre ventanas.
- **POO en C#** — clases, herencia, encapsulamiento y modelado de dominio.

---

## Cómo ejecutarlo

Requiere **.NET 6 SDK** y, para los proyectos web, **SQL Server LocalDB** (incluido con Visual Studio).

### Proyectos web

```bash
cd Examen3          # o cd CRUDWEB
dotnet restore
dotnet ef database update    # aplica las migraciones a LocalDB
dotnet run
```

### Proyectos de escritorio y consola

Windows Forms requiere Windows:

```bash
cd Calculadora/Calculadora   # o CRUD/CRUD, Examen2/examen2, Tarea3/Introduccion
dotnet run
```

```bash
cd Tarea2/Tarea2             # o Examen1/Examen1
dotnet run
```

También puedes abrir cada `.csproj` directamente en Visual Studio.

---

## Stack

`C#` · `.NET 6` · `ASP.NET Core MVC` · `Entity Framework Core` · `ASP.NET Identity` · `Windows Forms` · `SQL Server LocalDB` · `Razor`

---

## Autor

**Adalberto Cerrillo Vázquez** — Ingeniería de Software, Universidad Autónoma de Zacatecas.
