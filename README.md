1. Crear proyecto MVC
2. Generar modelos(clases)
3. Administrar paquetesNuGet para instalar EntityFramework
4. Se crea carpeta data la cual contendra el context para generar el enlace con la base de datos
5. Se modifica el program.cs para ir a buscar la cadena de conexion a la base de datos
6. En Connected Services se agrega la base de datos sql server express y se conecta a la base de datos local
7. Se agrega en el appsettings.json el connectionString
8. Ademas se debe agregar create scope para generar la base de datos al inciar el proyecto
9. En carpeta controller se agregan los controladores y se selecciona MVC para asi generar las vistas automaticamente con el CRUD
10. Se deben modificar los select de las vistas generadas para mostrar los enum
11. Agregar en modelo las restricciones y nombres a mostrar deseados en cada campo y/o validaciones
