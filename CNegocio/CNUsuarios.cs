using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos.Repositorios;
using System.Data;
using CDatos.Entidades;


namespace CNegocio
{
    public class CNUsuarios
    {
        public CDRUsuarios _CDRUsuairos = new CDRUsuarios();

        public DataTable GetAllUsuarios()
        {
            return _CDRUsuairos.GetAllUsuarios();
        }

        public bool FindUser(string Usuario, string Password)
        {
            CDUsuarios CDusuario = new CDUsuarios()
            {
                Usuario = Usuario,
                Password = Password
            };
            CDRUsuarios repositorio = new CDRUsuarios();
            DataTable dataTable = repositorio.FindUser(CDusuario);
            if(dataTable.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
