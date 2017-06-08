using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Data;
using System.Data.SqlClient;

namespace Mnham_Mnham
{
    class ClienteDAO : DAO
    {
        public ClienteDAO() : base()
        {
        }
        
        public ClienteDAO(string queryString) : base(queryString)
        {
        }

        internal Cliente ObterPorEmail(string email)
        {
            throw new NotImplementedException();
        }

        public bool Contains(string email, string password)
        {
            SqlCommand cmd = new SqlCommand("SELECT email FROM Cliente WHERE email = @email AND palavra_passe = @pp", base.sqlCon);

            cmd.Parameters.Add("@email", SqlDbType.NVarChar, 50);
            cmd.Parameters["@email"].Value = email;

            cmd.Parameters.Add("@pp", SqlDbType.Char, 32);
            cmd.Parameters["@pp"].Value = password;
            SqlDataReader reader = cmd.ExecuteReader();
            bool contains = false;

            try
            {
                contains = reader.Read();
            }
            finally
            {
                reader.Close();
            }
            return contains;
        }

        internal bool ContemEmail(string email)
        {
            throw new NotImplementedException();
        }

        internal void AdicionarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        internal Cliente ObterPorId(int clienteAutenticado)
        {
            throw new NotImplementedException();
        }

        internal void AdicionarPreferencia(int clienteAutenticado, Preferencia preferencia)
        {
            throw new NotImplementedException();
        }

        internal void AdicionarNaoPreferencia(int clienteAutenticado, Preferencia naoPreferencia)
        {
            throw new NotImplementedException();
        }

        internal void RemoverPreferencia(int clienteAutenticado, Preferencia preferencia)
        {
            throw new NotImplementedException();
        }

        internal void RemoverNaoPreferencia(int clienteAutenticado, Preferencia naoPreferencia)
        {
            throw new NotImplementedException();
        }
    }
}