//funskjon for å filtrere tabeller basert på inntasting i søkefeltet
//oversikt siden:
    function myFunctionOversikt() {
    //henter ut elementer fra HTML-documentet 
    var input, filter, table, tr, td, i, txtValue;
    input = document.getElementById("søkebarOversikt");
    filter = input.value.toUpperCase();
    table = document.getElementById("partsTable");
    tr = table.getElementsByTagName("tr");

    //går igjennom hver rad i tabellen
    for (i = 0; i < tr.length; i++) {
        //henter ut cellen i første kolonne for hver rad
    td = tr[i].getElementsByTagName("td")[0];
    if (td) {
        //henter teksten i cellen
    txtValue = td.textContent || td.innerText;
    //sjekker om teksten inneholder filtrert, og vis ellerskjul raden 
    if (txtValue.toUpperCase().indexOf(filter) > -1) {
    tr[i].style.display = "";
} else {
    tr[i].style.display = "none";
}
}
}
}


//brukeroversiktsiden: 
function myFunctionBrukerOversikt() {
    //henter elementer fra HTML-dokumentet
    var input, filter, table, tr, td0, td1, td2, i, txtValue0, txtValue1, txtValue2;
    input = document.getElementById("brukeroversiktInput");
    filter = input.value.toUpperCase();
    table = document.getElementById("partsTable");
    tr = table.getElementsByTagName("tr");
    //går igjennom hver rad som er  i tabellen
    for (i = 0; i < tr.length; i++) {
        td0 = tr[i].getElementsByTagName("td")[0];
        td1 = tr[i].getElementsByTagName("td")[1];
        td2 = tr[i].getElementsByTagName("td")[2];
        //henter cellene i første, andre og tredje kolonne for hver rad
        if (td0 && td1 && td2) {
            txtValue0 = td0.textContent || td0.innerText;
            txtValue1 = td1.textContent || td1.innerText;
            txtValue2 = td2.textContent || td2.innerText;

            // sjekker om filteret ligner på noen av kolonnene, og vis eller skjuler raden 
            if (txtValue0.toUpperCase().indexOf(filter) > -1 || txtValue1.toUpperCase().indexOf(filter) > -1 || txtValue2.toUpperCase().indexOf(filter) > -1) {
                tr[i].style.display = "";
            } else {
                tr[i].style.display = "none";
            }
        }
    }
}
