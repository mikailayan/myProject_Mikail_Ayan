 let index=0;
 
 $(document).ready(function(){
     showSlide(index)
    $(".btn2").click(function(){
        $("#ac-2").toggle();
      });
    $(".btn3").click(function(){
        $("#ac-3").toggle();
      });
      $(".btn4").click(function(){
        $("#ac-4").toggle();
      });
    $(".ileri").click(function(){
        if (index<3) {
            index=index+1;
            console.log("selam");
        }
        else
        {
            index=0;
            
        }
        console.log(index);
        showSlide(index)
        
    })
    $(".geri").click(function(){
        console.log("bas index"+ index);
        if (index>0) {
            
            console.log("if index" +index);
            showSlide(--index)
        }
        else
        {
            console.log("else index " + index);
            index=3
            showSlide(index)
            
        }
        console.log("son " +index);
        
        
    })
    
})

let allSlide = $(".img");

function showSlide(index){
    console.log("fonksiyon",index)
    for(let i = 0; i<allSlide.length; i++)
    { 
        allSlide[i].style.display="none";
    }
    allSlide[index].style.display="block";
    
}



