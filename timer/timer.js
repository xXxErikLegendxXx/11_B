const perc = 0.10;

let masodperc = perc * 60;


const csoken = setInterval(countdown,1000)

function countdown(){

    percb = Math.floor(masodperc / 60);
    masodpercb = Math.floor(masodperc % 60);

    masodpercb = masodpercb < 10 ? "0" + masodpercb: masodpercb;

    document.getElementById("timer").innerHTML = `${percb}:${masodpercb}`
    if(masodpercb < 1 ){

        clearInterval(csoken)

    }
    masodperc--;


}