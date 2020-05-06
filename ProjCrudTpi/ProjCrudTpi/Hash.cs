/**
 * Auteur : Inconnu
 * Projet : CRUD Préparation TPI
 * Date : 05.05.2020
 * Description : Programme qui permet de hasher un texte
 * Version 1.0
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ProjCrudTpi
{
    /// <summary>
    /// Class Hash
    /// </summary>
    class Hash
    {
        /// <summary>
        /// Fonction pour hasher un text
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string ComputeSha256Hash(string text)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                //Salt
                string salt = "mer";
                text = text + salt;

                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(text));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
