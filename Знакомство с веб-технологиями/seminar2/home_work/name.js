function ascName(names='Безымянный')
{
    document.getElementById('d1').innerHTML = (`Привет, ${names}!`);
}

let test = prompt("Как вас зовут ?");
if (test == '')
    ascName();
else
    ascName(test);