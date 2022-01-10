window.onload = runAfterWindowLoaded;

function runAfterWindowLoaded(eventArgs){

    let h2 = document.getElementsByTagName('h2');
    console.log(h2);
    h2[0].textContent = "JavaScript ist toll";

    let headline = document.getElementById("headline");
    console.log(headline);
    headline.innerHTML = "Hallo<br>Welt";

    let btn = document.getElementById('btnOK');
    btn.addEventListener('click', greeting);

        function greeting(){
            headline.innerHTML = "Servus";
        }
    
    console.log(eventArgs);

    document.getElementById('container1').addEventListener('mousedown',() => alert("container1"));
    document.getElementById('container2').addEventListener('mousedown',() => alert("container2"),true);
    document.getElementById('container3').addEventListener('mousedown',(event) => {
        alert("span");
        event.stopPropagation();
    });
    document.getElementById('buttonTest').addEventListener('mousedown',() => alert("buttonTest"));
}