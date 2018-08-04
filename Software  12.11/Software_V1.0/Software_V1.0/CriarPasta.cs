using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Software_V1._0
{
    class CriarPasta
    {
        public void PastaDoProjeto(string endereco, bool tipo,string nome)
        {
            #region criacao_diretorios_subdiretorios
            DirectoryInfo dic = new DirectoryInfo(@endereco);
            dic.Create();
            dic.CreateSubdirectory("Tipo");
            dic.CreateSubdirectory("Debug");
            Form1 fmr = new Form1();
            DataBase dt = new DataBase();
            //copiar arquivos
            #endregion

            if (!tipo)
            {
                #region copia_arquivos_necessarios_para_aplicação
                string sourceFile = System.IO.Path.Combine(fmr.app_path, "CompilaLadder4.exe");
                string destFile = System.IO.Path.Combine(endereco + "\\" + "Debug", "CompilaLadder4.exe");
                string dll_msvcp120d = System.IO.Path.Combine(fmr.app_path, "msvcp120d.dll");
                string dll_msvcr120d = System.IO.Path.Combine(fmr.app_path, "msvcr120d.dll");
                string dll_msvcp110d = System.IO.Path.Combine(fmr.app_path, "msvcp110d.dll");
                string dll_msvcr110d = System.IO.Path.Combine(fmr.app_path, "msvcr110d.dll");
                string destFile_dll_p = System.IO.Path.Combine(endereco + "\\" + "Debug", "msvcp120d.dll");
                string destFile_dll_r = System.IO.Path.Combine(endereco + "\\" + "Debug", "msvcr120d.dll");
                string destFile_dll_p10 = System.IO.Path.Combine(endereco + "\\" + "Debug", "msvcp110d.dll");
                string destFile_dll_r10 = System.IO.Path.Combine(endereco + "\\" + "Debug", "msvcr110d.dll");
                System.IO.File.Copy(sourceFile, destFile, true);//copia o exe para a pasta
                System.IO.File.Copy(dll_msvcp120d, destFile_dll_p, true);//copia dll
                System.IO.File.Copy(dll_msvcr120d, destFile_dll_r, true);//copia dll
                #endregion

            }
            else if (tipo)
            {
                dt.create(endereco +"\\Debug");
                dt.NewTable(endereco + "\\Debug");
                
            }
          
            
         
        }
        public void Arquivos(string endereco, string nomedoarquivo, string conteudo)
        {
            #region escreve_arquivo
            StreamWriter sw = new StreamWriter(endereco +"\\"+ nomedoarquivo);
            sw.Write(conteudo);
            sw.Close();
            #endregion


        }

    }
}
