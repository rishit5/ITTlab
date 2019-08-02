setInterval( function() {
	var d = new Date()
	document.getElementById('date').innerHTML = d.getDate();
	document.getElementById('month').innerHTML = d.getMonth();
	document.getElementById('year').innerHTML = d.getFullYear();
	document.getElementById('hours').innerHTML = d.getHours();
	document.getElementById('minutes').innerHTML = d.getMinutes();
	document.getElementById('seconds').innerHTML = d.getSeconds();
}, 1);

function showTime() {
	var d = new Date();
	if(d.getHours() >= 0 && d.getHours() < 12 ) {
		window.alert("Good morning");
	} else if(d.getHours() >= 12 && d.getHours() < 18 ) {
		window.prompt("Good AfterNoon");
	} else if(d.gethours() >= 18 && d.getHours() < 24 ) {
		window.alert("Good Night");
	}  
}