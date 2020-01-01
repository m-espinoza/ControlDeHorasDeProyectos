# Instalar y configurar Mysql.

1. Si no tenes Xampp instalado, descargá solo Mysql e instalalo. https://dev.mysql.com/downloads/mysql/5.5.html

2. Recomendación instalar el siguiente gestor de bases de datos.
   https://dbeaver.io/download/

3. Conectan su base de datos local a **DBEAVER**.

4. Para crear la base de datos ejecutar el siguiente comando.
   `CREATE DATABASE controlhorasproyectos;`

5. Luego ejecutar el comando sql que está en `./SQL/DataBase-controlhorasproyectos.sql`
   Pueden copiar el contenido de ese archivo y ejecutarlo desde **DBEAVER**.
   Con esto se les crearan todas las tablas que contiene la base de datos.

6. Una vez hecho esto, abran con Visual Studio el proyecto, y ahí deben configurar el el programa para conectarse a nuestra base de datos.
   
   Esto es muy sencillo ya que solo deben abrir y editar el archivo **./Properties/Settings.settings** en el campo **"Valor"**, con el server, usuario, contraseña y el nombre de la base de datos.
   
   ![alt Vusual Studio](https://github.com/m-espinoza/ControlDeHorasDeProyectos/blob/master/readmeimg/visualstudio.PNG)

7. Una vez configurado esto, hacen doble click sobre el archivo **ControlHorasProyecto.sin** esto les va a levantar la aplicación y la van a poder ejecutar.
