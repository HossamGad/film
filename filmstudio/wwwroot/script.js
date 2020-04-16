
document.getElementById('gettext').addEventListener
    ('click', gettext);
function gettext() {
    fetch("https://localhost:44306/api/Film")
        .then((res) => res.text())
        .then((data) => { document.getElementById('output').innerHTML = data })
}
document.getElementById('gettext1').addEventListener
    ('click', gettext1);
function gettext1() {
    fetch("https://localhost:44306/api/Film/Saw/90")
        .then((res) => res.text())
        .then((data1) => { document.getElementById('output1').innerHTML = data1 })
}

document.getElementById('gettext2').addEventListener
    ('click', gettext2);
function gettext2() {
    fetch("https://localhost:44306/api/Film/Into%20the%20blue/50")
        .then((res) => res.text())
        .then((data2) => { document.getElementById('output2').innerHTML = data2 })
}

document.getElementById('gettext3').addEventListener
    ('click', gettext3);
function gettext3() {
    fetch("https://localhost:44306/api/Film/Wrong%20turn")
        .then((res) => res.text())
        .then((data3) => { document.getElementById('output3').innerHTML = data3 })
}