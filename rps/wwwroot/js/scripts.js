var showBtn = 0;

$(function(){
  //PVC
  $("#pvp").click(function(){
    $("#pvpGame").show();
    $("#pvp").hide();
    $("#pvc").hide();
  });

  $("#pvc").click(function(){
    $("#pvcGame").show();
    $("#pvp").hide();
    $("#pvc").hide();
    $("#btnSubmitpvc").show();
  });

  //PVP
  $("#p1Choice button").click(function(){
    $("#p1Title").hide();
    $("#p1Choice").hide();
    $("#p1Chose").show();
    showBtn++;
    if(showBtn==2)
    {
      $("#btnSubmitpvp").show();
    }
  });
  $("#p2Choice button").click(function(){
  showBtn++;
    $("#p2Choice").hide();
    $("#p2Title").hide();
    $("#p2Chose").show();

    if(showBtn==2)
    {
        $("#btnSubmitpvp").show();
    }
  });
})
