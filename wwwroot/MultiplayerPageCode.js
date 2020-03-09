var a = sessionStorage.getItem("howmuch");

function onOkClicked()
{
    document.getElementById("nextplayercontainer").style.display = "none";
    setTime();

    var value = parseInt(document.getElementById("matbtnnext").value);
    value = isNaN(value) ? 0 : value;
    value++;
    document.getElementById("matbtnnext").value = value;

    var name = parseInt(document.getElementById("namenumber").innerHTML);
    name = isNaN(name) ? 0 : name;
    name++;
    mass.push({player: document.getElementById("playername").innerHTML + document.getElementById("namenumber").innerHTML, playerscore : document.getElementById("score").innerHTML});
    document.getElementById("namenumber").innerHTML = name;

    document.getElementById("seconds").innerHTML = 0;
    document.getElementById("score").innerHTML = 0;

    if(document.getElementById("matbtnnext").value == a)
    {
        
        showScore();
        document.getElementById("nextplayercontainer").style.display = "none";
        document.getElementById("resultall").style.display = "block";
    }
}

function openNav()
{
    document.getElementById('centralmenu').style.display = "block";
}
function closeNav()
{
    document.getElementById('centralmenu').style.display = "none";
}

var timeInterval = 10;
var count = 0;
var x = function(){
    document.getElementById("seconds").innerHTML = (timeInterval - count);
    count++;
    if(count > timeInterval)
    {
        showNextPlayerDiv();
        clearInterval(interval);
        return;
    }
};

function setTime()
{
    var timeInterval = 10;
    var count = 0;
    var x = function(){
        document.getElementById("seconds").innerHTML = (timeInterval - count);
        count++;
        if(count > timeInterval)
        {
            showNextPlayerDiv();
            clearInterval(interval);
            return;
        }
    };
    var interval = setInterval(x,1000);
}

function showNextPlayerDiv()
{
    document.getElementById("nextplayercontainer").style.display = "block";
}

var interval = setInterval(x,1000);

function onAppleClick()
{
    var value = parseInt(document.getElementById('score').innerHTML);
    value = isNaN(value) ? 0 : value;
    value++;
    document.getElementById("score").innerHTML = value;
}

var mass = Array();

function showScore()
{
    var table = document.createElement('table');
    var tbody = document.createElement('tbody');
    var tr = document.createElement('tr');
    tr.innerHTML = '<td style="color:#569981; font-weight:600; font-size:20px">Players</td><td style="color:#569981; font-weight:600; font-size:20px;">Score</td>';
    tbody.appendChild(tr);
    var items = ['player','playerscore'];
    for(var i = 0; i < mass.length; i++)
    {
        var tr = document.createElement('tr');
        for(var j = 0; j < 2; j++)
        {
            var td = document.createElement('td');
            var item = mass[i][items[j]];
            td.innerHTML = item;
            tr.appendChild(td);
        }
        tbody.appendChild(tr);
    }
    table.appendChild(tbody);
    document.getElementById("resultscoreall").appendChild(table);
}


