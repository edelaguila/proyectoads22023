using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using CapaControladorBancos;
using System.Data;

namespace CapaVistaBancos
{
   


   

        public class negocios
        {
            public static string noCuenta1;
            public static string noCuenta2;
            public static string tMoneda;
            public static string bancoN;
            public static string banconom;
            public static string nomBanco;
            public static double saldo;
            public static string SCuenta;
            public static double VMoneda;
            string no_form = "5004";

            public static void ObtenerID(string banco)
            {
                string ban;
                DataTable dtB = ControladorBanco.ObtenerIdBanco(banco); //Crear una DataTable donde guarda el resultado de ObtenerID
                if (dtB.Rows.Count > 0) //Si la tabla tiene alguna columna
                {
                    DataRow row = dtB.Rows[0]; //Inicializa columnas en la DataTable
                    ban = Convert.ToString(row["cori_tipo_de_compra"]);// Busca en las columnas la que se llame idBanco
                                                                       //MessageBox.Show("el id es" + ban); // Mensaje de prueba de funcionamiento
                    negocios.bancoN = ban; //Guarda el resultado de la consulta
                }
            }

            public static void ObtenerIdBanco(string noCuen)
            {
                string nBanco;
                DataTable dtS = ControladorBanco.idmoncu(noCuen);  //Crear una DataTable donde guarda el resultado de ObtenerID
                if (dtS.Rows.Count > 0) //Si la tabla tiene alguna col
                { //Si la tabla tiene alguna columna
                    DataRow row = dtS.Rows[0]; //Inicializa columnas en la DataTable
                    nBanco = Convert.ToString(row["cdes_id_compra"]); // Busca en las columnas la que se llame saldoDisponible
                                                                      // MessageBox.Show("El saldo de la cuenta " + noCuen + " es " + SCuenta); // Mensaje de prueba de funcionamiento
                    negocios.nomBanco = nBanco; //Guarda el resultado de la consulta
                }
            }

            public static void ObtenerSaldo(string noCuen)
            {
                string SCuenta;
                DataTable dtS = ControladorBanco.ObtenerSaldo(noCuen);  //Crear una DataTable donde guarda el resultado de ObtenerID
                if (dtS.Rows.Count > 0)
                { //Si la tabla tiene alguna columna
                    DataRow row = dtS.Rows[0]; //Inicializa columnas en la DataTable
                    SCuenta = Convert.ToString(row["cdes_saldoDisponible"]); // Busca en las columnas la que se llame saldoDisponible
                                                                             // MessageBox.Show("El saldo de la cuenta " + noCuen + " es " + SCuenta); // Mensaje de prueba de funcionamiento
                    saldo = Convert.ToDouble(SCuenta); //Guarda el resultado de la consulta
                }
            }

            public static void ObtenertMoneda(string noCuen)
            {

                DataTable dtS = ControladorBanco.ObtenertMoneda(noCuen);  //Crear una DataTable donde guarda el resultado de ObtenerID
                if (dtS.Rows.Count > 0)//Si la tabla tiene alguna col
                {
                    DataRow row = dtS.Rows[0];//Si la tabla tiene alguna columna
                    negocios.tMoneda = Convert.ToString(row["fk_cori_tipo_de_moneda"]); // Busca en las columnas la que se llame tipoMoneda
                                                                                        // MessageBox.Show("La moneda de la cuenta " + noCuen + " es " + tMoneda); // Mensaje de prueba de funcionamiento
                }
            }

            public static void ObtenerBancoCuenta(string noCuen)
            {

                DataTable dtS = ControladorBanco.idmoncu(noCuen);  //Crear una DataTable donde guarda el resultado de ObtenerID
                if (dtS.Rows.Count > 0)
                {
                    DataRow row = dtS.Rows[0]; //Inicializa columnas en la DataTable
                    negocios.banconom = Convert.ToString(row["cdes_id_compra"]);
                    // MessageBox.Show("La moneda de la cuenta " + noCuen + " es " + tMoneda); // Mensaje de prueba de funcionamiento
                }
            }

            public static void ObtenerValorM(string moneda)
            {
                string ValorM;
                DataTable dtS = ControladorBanco.ObtenerSaldo(moneda);  //Crear una DataTable donde guarda el resultado de ObtenerID
                if (dtS.Rows.Count > 0) //Inicializa columnas en la DataTable
                { //Si la tabla tiene alguna columna
                    DataRow row = dtS.Rows[0]; //Inicializa columnas en la DataTable
                    ValorM = Convert.ToString(row["cori_valor"]); // Busca en las columnas la que se llame saldoDisponible
                                                                  // MessageBox.Show("El saldo de la cuenta " + noCuen + " es " + SCuenta); // Mensaje de prueba de funcionamiento
                    VMoneda = Convert.ToDouble(ValorM); //Guarda el resultado de la consulta
                }
            }


            public static void TraspasoSaldo(string noCuenO, string noCuenD, double saldoO, double saldoD, double traslado)
            {
                double NuevoSaldoO;
                double NuevoSaldoD;
                string tmonedaO, tmonedaD;
                negocios.ObtenertMoneda(noCuenO);//Obtenemos el tipo de moneda del no. de cuenta de Origen
                tmonedaO = negocios.tMoneda;  //Establece la variable con el valor de la moneda para poder reutilizar el metodo posteriormente
                negocios.ObtenertMoneda(noCuenD); //Obtenemos el tipo de moneda del no. de cuenta Destino
                tmonedaD = negocios.tMoneda; //Establece la variable con el valor de la moneda para poder reutilizar el metodo posteriormente

                if (saldoO < traslado)
                {
                    MessageBox.Show("El saldo de la cuenta" + noCuenO + " es menor a la transaccion, COMPRA NO AUTORIZADA");//Validacion de saldo insuficiente
                }
                else
                {
                    if (tmonedaO == tmonedaD)
                    {  //Calculo nuevo saldo de origen
                        NuevoSaldoO = saldoO - traslado;
                    ControladorBanco.trasladoS(noCuenO, NuevoSaldoO);
                        //Calculo nuevo saldo de destino
                        NuevoSaldoD = saldoD + traslado;
                    ControladorBanco.trasladoS(noCuenD, NuevoSaldoD);
                        //Mensaje de autorizacion
                        MessageBox.Show("COMPRA AUTORIZADA");

                    }
                    else if ((tmonedaO == "Quetzales" || tmonedaO == "quetzales") && (tmonedaD == "Dolares" || tmonedaD == "dolares"))
                    { //Verificacion de tipos de moneda
                        MessageBox.Show("La cuenta de origen esta en quetzales, se realizara la conversion a dolares");
                        double valor, conver;
                        //Calculo nuevo saldo de origen
                        negocios.ObtenerValorM(tmonedaD);
                        valor = 7.34;
                        conver = traslado * valor;
                        if (saldoO < conver)
                        {
                            MessageBox.Show("El saldo de la cuenta" + noCuenO + " es menor a la transaccion, COMPRA NO AUTORIZADA");
                        }
                        else
                        {
                            NuevoSaldoO = saldoO - conver;
                        ControladorBanco.trasladoS(noCuenO, NuevoSaldoO); //

                            //Calculo nuevo saldo de destino
                            NuevoSaldoD = saldoD + traslado;
                        ControladorBanco.trasladoS(noCuenD, NuevoSaldoD);
                        }

                    }
                    else if ((tmonedaO == "Dolares" || tmonedaO == "dolares") && (tmonedaD == "Quetzales" || tmonedaD == "quetzales"))//Verificacion de tipos de moneda
                    {
                    ControladorBanco.Show("La cuenta de origen esta en dolares, se realizara la conversion a quetzales");
                        double valor, conver;
                        //Calculo nuevo saldo de origen
                        negocios.ObtenerValorM(tmonedaO);//Funcion para obtener el valor del la moneda AUN NO FUNCIONAL
                        valor = 7.34;
                        conver = traslado * valor; //Conversion de monedas para transaccion
                        if (saldoO < conver)
                        {
                            MessageBox.Show("El saldo de la cuenta" + noCuenO + " es menor a la transaccion, COMPRA NO AUTORIZADA");
                        }
                        else
                        {
                            NuevoSaldoO = saldoO - traslado; //Calculos de nuevo saldo
                        ControladorBanco.trasladoS(noCuenO, NuevoSaldoO); //Traslados

                            //Calculo nuevo saldo de destino
                            NuevoSaldoD = saldoD + conver; //Calculos de nuevo saldo
                        ControladorBanco.trasladoS(noCuenD, NuevoSaldoD); //Traslados
                            MessageBox.Show("COMPRA AUTORIZADA");
                        }


                    }

                }


            }



        }
    }

