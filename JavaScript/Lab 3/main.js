// ================================================ 1 ================================================
// a. get all images
allImgs1 = document.querySelectorAll("img") 
img1 = document.getElementsByName("firstImage")
img2 = document.getElementById("secondImg")

// b. get options in drop down list
cities = document.getElementsByName("City")[0].children;

// c. get all rows in table2
rows = document.getElementsByClassName("bPink")[0].children[0].children;

// d. all elements contains class fontBlue
fontBlues = document.getElementsByClassName("fontBlue");




 // ============================================== 2 ===================================================
 // a. get first anchor in second table
 firstAnchor = document.getElementsByTagName("table")[1].children[0].children[0].children[0].children[0];

 firstAnchor.setAttribute("href", "tranning.com");
 firstAnchor.innerText = "Trainnig";

 // b. get last image
 allImages = document.getElementsByTagName("img");
 lastImg = allImages[allImages.length - 1];
 lastImg.style.border = "solid pink 2px"

 // c. function to get all checkbox checked
 var allCheckedFun = function() {
    allCheckBoxes = document.getElementsByName("hoppy");
    for(var i = 0; i < allCheckBoxes.length; i++)
    {
        if (allCheckBoxes[i] === true)
            alert(allCheckBoxes[i].value)
    }
 }
 allCheckedFun();

 // d. find element with id 'example'
example = document.getElementById("example");
example.style.backgroundColor = "pink";


 // ================================================ 3 ====================================================


 