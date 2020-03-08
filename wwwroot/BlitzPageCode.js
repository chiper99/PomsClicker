function openNav()
{
    document.getElementById('centralmenu').style.display = "block";
}
function closeNav()
{
    document.getElementById('centralmenu').style.display = "none";
}

var timeInterval = 60;
var count = 0;
var secondsTimer;
var x = function(){
    document.getElementById("seconds").innerHTML = (timeInterval - count);
    secondsTimer = (timeInterval - count);
    count++;
    if(count > timeInterval)
    {
        clearInterval(interval);
        return;
    }
};
var interval = setInterval(x,1000);


var randomNum1;
var randomNum2;
var tomato = '<img class="tomatopic" id="tomatopic" src="Assets/Cherry.jpg" style="width:100%; height:100%" onclick="ErrorAlert()">';
var apple = '<img class="applepic" id="applepic" src="Assets/Apple.png" style="width:100%; height:100%" onclick="onAppleClick()">';

function randomBlock()
{        
    randomNum1 = Math.floor(Math.random() * 16);
    var randomTd1 = $('#clickabletable td').eq(randomNum1);
    randomTd1.append(apple);
};

function randomSecondBlock()
{
    randomNum2 = Math.floor(Math.random() * 16);
    var randomTd2 = $('#clickabletable td').eq(randomNum2);
    if(!(randomNum1 == randomNum2))
    {
        randomTd2.append(tomato);
    }
};

function clearTable()
{
    var apples = document.getElementsByClassName("applepic");
    for(i=0; i<apples.length;i++)
    {
        apples[i].remove();
    }
    var tomatoes = document.getElementsByClassName("tomatopic");
    for(i = 0; i<tomatoes.length;i++)
    {
        tomatoes[i].remove();
    }
};

var time;

$(document).ready(function()
{
    var func = function()
    {
        clearTable();
        randomBlock();
        randomSecondBlock();
        time = 3000;
        switch(true)
        {
            
            case (secondsTimer<50 && secondsTimer >= 40):
                time *= 0.7;
                break;
            case (secondsTimer<40 && secondsTimer >= 30):
                time *= 0.49;
                break;
            case (secondsTimer<30 && secondsTimer >= 20):
                time *=  0.343;
                break;
            case (secondsTimer<20 && secondsTimer >= 10):
                time *= 0.2401;
                break;
            case (secondsTimer<10 && secondsTimer > 0):
                time *= 0.16807;
                break;
            default:
                time = 3000;
        }
        if(secondsTimer <=0)
        {
            document.getElementById("erroralert").style.display = "block";
            time = 50000;
        }
        setTimeout(func,time);
        
    }
    
    func();
    
                
});

function ErrorAlert()
{
    document.getElementById("losetext").style.display = "block";
    document.getElementById("erroralert").style.display = "block";
    time = 50000;
    document.getElementById("scoretext").innerHTML = document.getElementById("score").innerHTML;
};

function onAppleClick()
{
    clearTable();
        randomBlock();
        randomSecondBlock();
    var value = parseInt(document.getElementById('score').innerHTML);
    value = isNaN(value) ? 0 : value;
    value++;
    document.getElementById("score").innerHTML = value;
}
