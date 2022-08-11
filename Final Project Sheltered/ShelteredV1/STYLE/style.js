var navbar = document.getElementById("navbar");
var menu = document.getElementById("menu");
        
        window.onscroll=function()
        {
            if(window.pageYOffset>=menu.offsetTop)
            {
                navbar.classList.add("sticky");
            }
            else
            {
                navbar.classList.remove("sticky");
            }
        }

var productimg = document.getElementById("productimg");
var smallimg = document.getElementsByClassName("small-img");
        smallimg[0].onclick = function()
        {
            productimg.src=smallimg[0].src;
        }
        smallimg[1].onclick = function()
        {
            productimg.src=smallimg[1].src;
        }
        smallimg[2].onclick = function()
        {
            productimg.src=smallimg[2].src;
        }
        smallimg[3].onclick = function()
        {
            productimg.src=smallimg[3].src;
        }