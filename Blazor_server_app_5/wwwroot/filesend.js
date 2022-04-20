
window.change = () => {
    setTimeout(() => {
        var wrapper = document.getElementsByClassName("e-control-container")[0];
        if (wrapper.classList.contains('e-error')) {
            document.getElementsByClassName("AutoLabel")[0].style.color = "red"
        }
        else {
            document.getElementsByClassName("AutoLabel")[0].style.color = "black";
        }
        }, 300);
  
};