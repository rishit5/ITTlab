function bounceBall() {
	var c = document.getElementById('canvas');
	var ctx = c.getContext('2d');
	var topLeftx = document.getElementById('box').offsetLeft;
	var topLefty = document.getElementById('box').offsetTop;
	var width = document.getElementById('box').width;
	var height = 400;
	var x = 20;
	var y = 20;
	dir = 0;
	setInterval(function() {
		ctx.clearRect(0, 0, 400, 400);
		ctx.beginPath();
		ctx.arc(x, y, 20, 0, 2*Math.PI, true);
		if(dir == 0) {
			x+=0.5;
			y+=0.5;
			if(x > 120 && y > 120 ) {
				dir = 1;
			} 
		} else if( dir == 1 ){
			x+=0.5; 
			y-=0.5;
			if(y == 0 ) {
				dir = 2;
			} 
		} else if(dir == 2) {
			x-=0.5;
			y+=0.5;
			if(x == 150) {
				dir = 3;
			}
		}else if(dir == 3 ) {
			x-=0.5;
			y-=0.5;
			if(x== 0) {
				dir = 0; 
			}
		}
		ctx.stroke();
	}, 1);
}