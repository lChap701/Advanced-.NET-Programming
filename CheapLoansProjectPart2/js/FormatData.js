/**
 * Formats data as soon as the ID LoanAmt or AnnualIntRate loses focus
 * 
 * @param {HTMLInputElement} el  Represents the element that is no longer in focus
 */
function formatData(el) {

    if (el.id == "LoanAmt" && el.value != "") {
        el.value = parseFloat(el.value).toFixed(2);
    } else if (el.id == "AnnualIntRate" && el.value != "") {
        el.value = parseFloat(el.value).toFixed(1);
    } else if (el.id == "NumPayments" && el.value != "") {
        el.value = parseInt(el.value).toString();
    }
}
document.getElementById("LoanAmt").addEventListener("blur", function (e) { formatData(e.target); }, true);
document.getElementById("AnnualIntRate").addEventListener("blur", function (e) { formatData(e.target); }, true);
document.getElementById("NumPayments").addEventListener("blur", function (e) { formatData(e.target); }, true);