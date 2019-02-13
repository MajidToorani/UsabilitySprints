/*
 * Assignment #1
 * Majid Tooranisama , Created : Feb 5, 2019
 */
 function BackColor(color) {
    var myText = document.getElementById("US1originalText").value;    
    document.getElementById("greenBackground").value = myText;
    document.getElementById("greenBackground").style.backgroundColor = color;
};

String.prototype.reverse = function () {
    return this.split('').reverse().join('');
}

function ReverseMyText() {
    var myText = document.getElementById("US5originalText").value;
    var reversed = myText.reverse();
    document.getElementById("reversedText").value = reversed;
};

function Bold() {
    var myText = document.getElementById("US3originalText").value;
    var bolded = myText.bold();
    document.getElementById("boldText").innerHTML = bolded;
};

function Italicize() {
    var myText = document.getElementById("US4originalText").value;
    var italic = myText.italics();
    document.getElementById("italicizedText").innerHTML = italic;
};

function ChangeBackground(color) {
    document.body.style.backgroundColor = color;
};

