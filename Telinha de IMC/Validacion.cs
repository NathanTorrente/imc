using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Telinha_de_IMC
{

    public static class Validacion
    {
        public static bool ValidarCPF(string cpf)
        {
            cpf = cpf.Replace("-", "");
            cpf = cpf.Replace(".", "");
            MessageBox.Show(cpf);


            int contador = 0; // 0, 1, 2 , 3
            int soma = 0; // 0, 5, 3, 6


            if (cpf.Length != 11)                                                    // lenght e para ver quantos caracteres possui a variavel
            {
                return false;
            }
            else
            {
                for (int i = 10; i > 2; i--)        //053.643.911-74
                {                                    
                    int armazenarCal = Convert.ToInt32(cpf[contador].ToString());   // Converti cpf para string e depois int
                                                                              // preciso pegar cada posição do cpf individualmente
                    soma += armazenarCal * i;

                    MessageBox.Show((armazenarCal * i).ToString());
                    contador++;

                   

                    // SOMA +1 as posição do cpf e vai para proxima posição
                }

                if (soma % 11 < 2)
                {
                    soma = 0; // obrigatorio o primeiro digito verificador dever ser zero
                }
                else if (soma % 11 >= 2)
                {
                    soma = 11 - (soma % 11);

                }
               
                if (Convert.ToInt32(cpf[9].ToString()) == soma)
                {
                    int contador2 = 0; // reiniciar o contador para o segundo loop
                    int soma2 = 0;

                    for (int i = 11; i > 1; i--)        //053.643.911-74
                    {
                        int armazenarCal = Convert.ToInt32(cpf[contador2].ToString());

                        soma2 += armazenarCal * i;

                        contador2++;
                    }

                    if (soma2 % 11 < 2)
                    {
                        soma2 = 0;
                    }
                    else if (soma2 % 11 >= 2)
                    {
                        soma2 = 11 - (soma2 % 11);
                    }
                    if (Convert.ToInt32(cpf[10].ToString()) == soma2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                   
                }

                else { return false; }

            }
        }



    }
}
