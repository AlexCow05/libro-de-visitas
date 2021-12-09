using System;

public class LibroVisitasBase
{
    public string leer();
    {
        StreamReader archivo = new StreamReader(System.Web.Hosting.HostingEnvironment.MapPath("~") + "/App_Data/Datos.txt");
        String todo = archivo.ReadToEnd();
        archivo.Close();
        return todo;
}