# Product Develop for CRUD Products

Aplicacion de consola en .NET para gestión CRUD de Productos con Entity Framework y SQL Server.

## Requires

- .NET 9.0 
- Entity Framework Core 9.0.4
- SQL Server (Incluido Visual Studio)

## Configuration

optionsBuilder.UseSqlServer("Server=Tu-LocalHost;Database=CRUDComputers;Trusted_Connection=True;TrustServerCertificate=True;");

## Menú Principal

==MENU INTERACCIÓN CRUD - PRUEBA DESARROLLO==
1. Lista de Productos
2. Agregar
3. Editar
4. Eliminar
5. Salir

## Estructura de Proyecto

/Controller
	ProductController.cs # Service / Controller (Lógica CRUD)

/Data
	ApplicationDbContext.cs # Entidad Configuración DB - EF

/Model
	Products.cs # Entidad Principal

Program.cs # Menú Interactivo
