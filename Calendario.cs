using System;
using System.Reflection;

public class Calendario {
    
    public Byte Mes { get; set; }
    public UInt16 Ano { get; set; }

    public Boolean isMesValido(){
        if (this.Mes < 13 && this.Mes > 0){
            return true;
        }
        else {
            return false;
        }
    }
    
    public Boolean isAnoValido(){ 
        if (this.Ano < 9999 && this.Ano > 0){
            return true;
        }
        else {
            return false;
        }
    }

    public string gerarCalendario(){
        return null;
    }
    
    public override String ToString(){
        return Mes + " " + Ano + " " + isMesValido() + " " + isAnoValido();
    }
}