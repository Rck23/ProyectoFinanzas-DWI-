﻿namespace ProyectoFinanzas_DWI_.Services
{
    public interface IServicioUsuarios
    {
        int ObtenerUsuarioId();

    }
    public class ServicioUsuarios: IServicioUsuarios
    {
        public int ObtenerUsuarioId()
        {
            return 1;
        }
    }

    
}