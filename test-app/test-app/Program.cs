// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using Test_app;

Auto miaAuto;

//qui valorizzo le variabili tramite il costruttore con i paramentri 
miaAuto = new Auto("ferrari", "puro sangue", "rosso", Auto.motori.benzina);

miaAuto.stampadescizione();
miaAuto.stampastato();


miaAuto.accendi();

miaAuto.stampastato();

Console.ReadLine();

/*Modellare un automobile con 4 proprietà:   
 * marca
 * modello
 * tipo di motore (benzina, diesel, elettrico)
 * colore
 * All'avvio l'app deve mostrare lo stato dell'auto, stampando marca, modello, colore e tipo di motore.
*/

//devo modellare l'automobile impletando una classe chiamata auto

    

   
