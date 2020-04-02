

function SetupModelBox() {

    var cGE = $("#chkGE").is(":checked");
    var cSiemens = $("#chkSiemens").is(":checked");
    var cToshiba = $("#chkToshiba").is(":checked");
    var cOthers = $("#chkOthers").is(":checked");
    var cSamsung = $("#chkSamsung").is(":checked");
    var cMediso = $("#chkMediso").is(":checked");
    var cElscint = $("#chkElscint").is(":checked");
    var cSegami = $("#chkSegami").is(":checked");


    var elementRef = document.getElementById('chkboxModel');
    var checkBoxArray = elementRef.getElementsByTagName('input');


    for (var i = 0; i < checkBoxArray.length; i++) {

        var checkBoxRef = checkBoxArray[i];

        var labelArray = checkBoxRef.parentNode.getElementsByTagName('label');

        if (labelArray.length > 0) {

            var myCheckBox = document.getElementById(labelArray[0].htmlFor)
            var res = myCheckBox.value.split("|");



            myCheckBox.checked = false;
            labelArray[0].style.display = "none";
            myCheckBox.style.display = "none";
            // style.display = "none";


            if (res[0] == 'GE') {
                if (cGE == true & ValidateModality(res[1]) == true) {
                    labelArray[0].style.display = "block";
                    myCheckBox.style.display = "block";
                } else {
                    myCheckBox.checked = false;
                    labelArray[0].style.display = "none";
                    myCheckBox.style.display = "none";
                }
            }

            if (res[0] == 'Siemens') {
                if (cSiemens == true & ValidateModality(res[1]) == true) {
                    labelArray[0].style.display = "block";
                    myCheckBox.style.display = "block";
                } else {
                    myCheckBox.checked = false;
                    labelArray[0].style.display = "none";
                    myCheckBox.style.display = "none";
                }
            }

            if (res[0] == 'Toshiba') {
                if (cToshiba == true & ValidateModality(res[1]) == true) {
                    labelArray[0].style.display = "block";
                    myCheckBox.style.display = "block";
                } else {
                    myCheckBox.checked = false;
                    labelArray[0].style.display = "none";
                    myCheckBox.style.display = "none";
                }
            }

            if (res[0] == 'Others') {
                if (cOthers == true & ValidateModality(res[1]) == true) {
                    labelArray[0].style.display = "block";
                    myCheckBox.style.display = "block";
                } else {
                    myCheckBox.checked = false;
                    labelArray[0].style.display = "none";
                    myCheckBox.style.display = "none";
                }
            }

            if (res[0] == 'Samsung') {
                if (cSamsung == true & ValidateModality(res[1]) == true) {
                    labelArray[0].style.display = "block";
                    myCheckBox.style.display = "block";
                } else {
                    myCheckBox.checked = false;
                    labelArray[0].style.display = "none";
                    myCheckBox.style.display = "none";
                }
            }

            if (res[0] == 'Mediso') {
                if (cMediso == true & ValidateModality(res[1]) == true) {
                    labelArray[0].style.display = "block";
                    myCheckBox.style.display = "block";
                } else {
                    myCheckBox.checked = false;
                    labelArray[0].style.display = "none";
                    myCheckBox.style.display = "none";
                }
            }

            if (res[0] == 'Elscint') {
                if (cElscint == true & ValidateModality(res[1]) == true) {
                    labelArray[0].style.display = "block";
                    myCheckBox.style.display = "block";
                } else {
                    myCheckBox.checked = false;
                    labelArray[0].style.display = "none";
                    myCheckBox.style.display = "none";
                }
            }

            if (res[0] == 'Segami') {
                if (cSegami == true & ValidateModality(res[1]) == true) {
                    labelArray[0].style.display = "block";
                    myCheckBox.style.display = "block";
                } else {
                    myCheckBox.checked = false;
                    labelArray[0].style.display = "none";
                    myCheckBox.style.display = "none";
                }
            }







        }

    }



    if (document.getElementById('hidViewer').value == 'VIEW') {
        checkBoxArray = elementRef.getElementsByTagName('input');
        var allEmpty = 0;
        for (var i = 0; i < checkBoxArray.length; i++) {
            var checkBoxRef = checkBoxArray[i];
            var labelArray = checkBoxRef.parentNode.getElementsByTagName('label');
            var myCheckBox = document.getElementById(labelArray[0].htmlFor)

            if (myCheckBox.hidden == false) {
                if (myCheckBox.checked == true) {
                    allEmpty++;
                }
            }
        }


        checkBoxArray = elementRef.getElementsByTagName('input');
        if (allEmpty == 0) {
            for (var i = 0; i < checkBoxArray.length; i++) {
                var checkBoxRef = checkBoxArray[i];
                var labelArray = checkBoxRef.parentNode.getElementsByTagName('label');
                var myCheckBox = document.getElementById(labelArray[0].htmlFor)

                if (myCheckBox.hidden == false) {
                    if (myCheckBox.checked == false) {
                        myCheckBox.checked = true;
                        break;
                    }
                }
            }
        }

    }

}

function SetupSoftwareBox() {

    var cGE = $("#chkGE").is(":checked");
    var cSiemens = $("#chkSiemens").is(":checked");
    var cToshiba = $("#chkToshiba").is(":checked");
    var cOthers = $("#chkOthers").is(":checked");
    var cSamsung = $("#chkSamsung").is(":checked");
    var cMediso = $("#chkMediso").is(":checked");
    var cElscint = $("#chkElscint").is(":checked");
    var cSegami = $("#chkSegami").is(":checked");

    var elementRef = document.getElementById('chkboxSoftware');
    var checkBoxArray = elementRef.getElementsByTagName('input');


    for (var i = 0; i < checkBoxArray.length; i++) {

        var checkBoxRef = checkBoxArray[i];
        var labelArray = checkBoxRef.parentNode.getElementsByTagName('label');

        if (labelArray.length > 0) {

            var myCheckBox = document.getElementById(labelArray[0].htmlFor)
            var res = myCheckBox.value.split("|");

            myCheckBox.checked = false;
            labelArray[0].style.display = "none";
            myCheckBox.style.display = "none";

            if (res[1] == 'GE') {
                if (cGE == true & ValidateModality(res[0]) == true) {
                    labelArray[0].style.display = "block";
                    myCheckBox.style.display = "block";
                } else {
                    myCheckBox.checked = false;
                    labelArray[0].style.display = "none";
                    myCheckBox.style.display = "none";
                }
            }

            if (res[1] == 'Siemens') {
                if (cSiemens == true & ValidateModality(res[0]) == true) {
                    labelArray[0].style.display = "block";
                    myCheckBox.style.display = "block";
                } else {
                    myCheckBox.checked = false;
                    labelArray[0].style.display = "none";
                    myCheckBox.style.display = "none";
                }
            }

            if (res[1] == 'Toshiba') {
                if (cToshiba == true & ValidateModality(res[0]) == true) {
                    labelArray[0].style.display = "block";
                    myCheckBox.style.display = "block";
                } else {
                    myCheckBox.checked = false;
                    labelArray[0].style.display = "none";
                    myCheckBox.style.display = "none";
                }
            }

            if (res[1] == 'Others') {
                if (cOthers == true & ValidateModality(res[0]) == true) {
                    labelArray[0].style.display = "block";
                    myCheckBox.style.display = "block";
                } else {
                    myCheckBox.checked = false;
                    labelArray[0].style.display = "none";
                    myCheckBox.style.display = "none";
                }
            }


            if (res[1] == 'Samsung') {
                if (cSamsung == true & ValidateModality(res[0]) == true) {
                    labelArray[0].style.display = "block";
                    myCheckBox.style.display = "block";
                } else {
                    myCheckBox.checked = false;
                    labelArray[0].style.display = "none";
                    myCheckBox.style.display = "none";
                }
            }

            if (res[1] == 'Mediso') {
                if (cMediso == true & ValidateModality(res[0]) == true) {
                    labelArray[0].style.display = "block";
                    myCheckBox.style.display = "block";
                } else {
                    myCheckBox.checked = false;
                    labelArray[0].style.display = "none";
                    myCheckBox.style.display = "none";
                }
            }

            if (res[1] == 'Elscint') {
                if (cElscint == true & ValidateModality(res[0]) == true) {
                    labelArray[0].style.display = "block";
                    myCheckBox.style.display = "block";
                } else {
                    myCheckBox.checked = false;
                    labelArray[0].style.display = "none";
                    myCheckBox.style.display = "none";
                }
            }

            if (res[1] == 'Segami') {
                if (cSegami == true & ValidateModality(res[0]) == true) {
                    labelArray[0].style.display = "block";
                    myCheckBox.style.display = "block";
                } else {
                    myCheckBox.checked = false;
                    labelArray[0].style.display = "none";
                    myCheckBox.style.display = "none";
                }
            }



            if (res[1] == '') {

                myCheckBox.checked = false;
                labelArray[0].hidden = true;
                myCheckBox.hidden = true;

            }


        }
    }



    if (document.getElementById('hidViewer').value == 'VIEW') {
        checkBoxArray = elementRef.getElementsByTagName('input');
        var allEmpty = 0;
        for (var i = 0; i < checkBoxArray.length; i++) {
            var checkBoxRef = checkBoxArray[i];
            var labelArray = checkBoxRef.parentNode.getElementsByTagName('label');
            var myCheckBox = document.getElementById(labelArray[0].htmlFor)

            if (myCheckBox.hidden == false) {
                if (myCheckBox.checked == true) {
                    allEmpty++;
                }
            }
        }


        checkBoxArray = elementRef.getElementsByTagName('input');
        if (allEmpty == 0) {
            for (var i = 0; i < checkBoxArray.length; i++) {
                var checkBoxRef = checkBoxArray[i];
                var labelArray = checkBoxRef.parentNode.getElementsByTagName('label');
                var myCheckBox = document.getElementById(labelArray[0].htmlFor)

                if (myCheckBox.hidden == false) {
                    if (myCheckBox.checked == false) {
                        myCheckBox.checked = true;
                        break;
                    }
                }
            }
        }

    }

}


function SetupDomainBox() {


    var elementRef = document.getElementById('chkboxDomain');
    var checkBoxArray = elementRef.getElementsByTagName('input');


    for (var i = 0; i < checkBoxArray.length; i++) {

        var checkBoxRef = checkBoxArray[i];
        var labelArray = checkBoxRef.parentNode.getElementsByTagName('label');

        if (labelArray.length > 0) {

            var myCheckBox = document.getElementById(labelArray[0].htmlFor)
            var res = myCheckBox.value.split("|");


            if (ValidateModality(res[0]) == true) {

                labelArray[0].style.display = "block";
                myCheckBox.style.display = "block";
            } else {
                myCheckBox.checked = false;
                labelArray[0].style.display = "none";
                myCheckBox.style.display = "none";


            }
        }
    }
}


function SetupModuleBox() {


    var elementRef = document.getElementById('chkboxModule');
    var checkBoxArray = elementRef.getElementsByTagName('input');


    for (var i = 0; i < checkBoxArray.length; i++) {

        var checkBoxRef = checkBoxArray[i];
        var labelArray = checkBoxRef.parentNode.getElementsByTagName('label');

        if (labelArray.length > 0) {

            var myCheckBox = document.getElementById(labelArray[0].htmlFor)
            var res = myCheckBox.value.split("|");

            if (ValidateModality(res[0]) == true) {

                //does domain show in list
                if (IsDomainChecked() == true) {

                    if (ValidateDomain(res[2]) == true) {
                        labelArray[0].style.display = "block";
                        myCheckBox.style.display = "block";
                    } else {
                        labelArray[0].style.display = "none";
                        myCheckBox.style.display = "none";
                    }

                }
                else {
                    labelArray[0].style.display = "block";
                    myCheckBox.style.display = "block";
                }


            } else {
                myCheckBox.checked = false;
                labelArray[0].style.display = "none";
                myCheckBox.style.display = "none";

            }

        }

    }

}


function IsDomainChecked() {

    var elementRef = document.getElementById('chkboxDomain');
    var checkBoxArray = elementRef.getElementsByTagName('input');


    for (var i = 0; i < checkBoxArray.length; i++) {

        var checkBoxRef = checkBoxArray[i];
        var labelArray = checkBoxRef.parentNode.getElementsByTagName('label');

        if (labelArray.length > 0) {

            var myCheckBox = document.getElementById(labelArray[0].htmlFor)

            if (myCheckBox.checked == true) {
                return true;
            }


        }
    }

}


function ValidateDomain(res) {

    var elementRef = document.getElementById('chkboxDomain');
    var checkBoxArray = elementRef.getElementsByTagName('input');


    for (var i = 0; i < checkBoxArray.length; i++) {

        var checkBoxRef = checkBoxArray[i];
        var labelArray = checkBoxRef.parentNode.getElementsByTagName('label');

        if (labelArray.length > 0) {

            var myCheckBox = document.getElementById(labelArray[0].htmlFor)
            var resultBox = myCheckBox.value.split("|");


            if (myCheckBox.checked == true) {
                if (res == resultBox[1]) {
                    return true;
                }
            }


        }
    }

}

function ValidateModality(ListValue) {

    var cCT = $("#chkCT").is(":checked");
    var cMR = $("#chkMR").is(":checked");
    var cMMV = $("#chkMMV").is(":checked");
    var cSPECT = $("#chkNMSpect").is(":checked");
    var cSPET = $("#chkNMPet").is(":checked");


    switch (ListValue) {
        case "CT":
            if (cCT == true) {
                return true;
            }
            break;
        case "MR":
            if (cMR == true) {
                return true;
            }
            break;
        case "US":
            if (cMMV == true) {
                return true;
            }
            break;
        case "NM-SPECT":
            if (cSPECT == true) {
                return true;
            }
            break;
        case "NM-PET":
            if (cSPET == true) {
                return true;
            }
            break;
        default:
            return false;
            break;
    }


}


$(document).ready(function () {



    SetupModelBox();
    SetupSoftwareBox();
    SetupDomainBox();
    SetupModuleBox();

    $("#chkISP").is(":checked") ? $(".isp").show() : $(".isp").hide();
    $("#chkColModality").is(":checked") ? $(".modality").show() : $(".modality").hide();
    $("#chkColVendor").is(":checked") ? $(".vendor").show() : $(".vendor").hide();
    $("#chkColModel").is(":checked") ? $(".model").show() : $(".model").hide();
    $("#chkColSoftware").is(":checked") ? $(".version").show() : $(".version").hide();
    $("#chkColDomain").is(":checked") ? $(".domain").show() : $(".domain").hide();
    $("#chkColModule").is(":checked") ? $(".module").show() : $(".module").hide();
    //$("#chkColDefinition").is(":checked") ? $(".Definition").show() : $(".Definition").hide();


    $("#chkGreenFilter").is(":checked") ? $(".g").parent().show() : $(".g").parent().hide();
    $("#chkYellowFilter").is(":checked") ? $(".yellow").parent().show() : $(".yellow").parent().hide();
    $("#chkRedFilter").is(":checked") ? $(".red").parent().show() : $(".red").parent().hide();
    $("#chkOrangeFilter").is(":checked") ? $(".orange").parent().show() : $(".orange").parent().hide();

    $("#chkWhiteFilter").is(":checked") ? $(".white").parent().show() : $(".white").parent().hide();



})


$('#chkboxDomain').on('change', 'input[type=checkbox]', function () {

    SetupModuleBox();

});


$("#chkSiemens").change(function () {

    SetupModelBox();
    SetupSoftwareBox();
    SetupDomainBox();
});

$("#chkGE").change(function () {

    SetupModelBox();
    SetupSoftwareBox();
    SetupDomainBox();
});

$("#chkToshiba").change(function () {

    SetupModelBox();
    SetupSoftwareBox();
    SetupDomainBox();
});
$("#chkOthers").change(function () {

    SetupModelBox();
    SetupSoftwareBox();
    SetupDomainBox();
});
$("#chkSamsung").change(function () {

    SetupModelBox();
    SetupSoftwareBox();
    SetupDomainBox();
});
$("#chkMediso").change(function () {

    SetupModelBox();
    SetupSoftwareBox();
    SetupDomainBox();
});
$("#chkElscint").change(function () {

    SetupModelBox();
    SetupSoftwareBox();
    SetupDomainBox();
});
$("#chkSegami").change(function () {

    SetupModelBox();
    SetupSoftwareBox();
    SetupDomainBox();
});








$("#chkMR").change(function () {

    SetupModelBox();
    SetupSoftwareBox();
    SetupDomainBox();
    SetupModuleBox();

    var btn = $("#chkboxModelToggle").data("ejToggleButton");
    if (btn != null) {
        btn.option("toggleState", false);
    }


    var btn = $("#chkboxSoftwareToggle").data("ejToggleButton");
    if (btn != null) {
        btn.option("toggleState", false);
    }

    var btn = $("#chkboxDomainToggle").data("ejToggleButton");
    if (btn != null) {
        btn.option("toggleState", false);
    }

    var btn = $("#OnchkModuleToggle").data("ejToggleButton");
    if (btn != null) {
        btn.option("toggleState", false);
    }

    var btn = $("#OnchkDefinitionToggle").data("ejToggleButton");
    if (btn != null) {
        btn.option("toggleState", false);
    }

});

$("#chkCT").change(function () {

    SetupModelBox();
    SetupSoftwareBox();
    SetupDomainBox();
    SetupModuleBox();

    var btn = $("#chkboxModelToggle").data("ejToggleButton");
    btn.option("toggleState", false);


    var btn = $("#chkboxSoftwareToggle").data("ejToggleButton");
    btn.option("toggleState", false);

    var btn = $("#chkboxDomainToggle").data("ejToggleButton");
    btn.option("toggleState", false);

    var btn = $("#OnchkModuleToggle").data("ejToggleButton");
    btn.option("toggleState", false);

    var btn = $("#OnchkDefinitionToggle").data("ejToggleButton");
    btn.option("toggleState", false);




});



$("#chkMMV").change(function () {

    SetupModelBox();
    SetupSoftwareBox();
    SetupDomainBox();
    SetupModuleBox();

    var btn = $("#chkboxModelToggle").data("ejToggleButton");
    btn.option("toggleState", false);


    var btn = $("#chkboxSoftwareToggle").data("ejToggleButton");
    btn.option("toggleState", false);

    var btn = $("#chkboxDomainToggle").data("ejToggleButton");
    btn.option("toggleState", false);

    var btn = $("#OnchkModuleToggle").data("ejToggleButton");
    btn.option("toggleState", false);

    var btn = $("#OnchkDefinitionToggle").data("ejToggleButton");
    btn.option("toggleState", false);

});

$("#chkNMSpect").change(function () {

    SetupModelBox();
    SetupSoftwareBox();
    SetupDomainBox();
    SetupModuleBox();

    var btn = $("#chkboxModelToggle").data("ejToggleButton");
    btn.option("toggleState", false);


    var btn = $("#chkboxSoftwareToggle").data("ejToggleButton");
    btn.option("toggleState", false);

    var btn = $("#chkboxDomainToggle").data("ejToggleButton");
    btn.option("toggleState", false);

    var btn = $("#OnchkModuleToggle").data("ejToggleButton");
    btn.option("toggleState", false);

    var btn = $("#OnchkDefinitionToggle").data("ejToggleButton");
    btn.option("toggleState", false);

});

$("#chkNMPet").change(function () {

    SetupModelBox();
    SetupSoftwareBox();
    SetupDomainBox();
    SetupModuleBox();

    var btn = $("#chkboxModelToggle").data("ejToggleButton");
    btn.option("toggleState", false);


    var btn = $("#chkboxSoftwareToggle").data("ejToggleButton");
    btn.option("toggleState", false);

    var btn = $("#chkboxDomainToggle").data("ejToggleButton");
    btn.option("toggleState", false);

    var btn = $("#OnchkModuleToggle").data("ejToggleButton");
    btn.option("toggleState", false);

    var btn = $("#OnchkDefinitionToggle").data("ejToggleButton");
    btn.option("toggleState", false);

});



//hide show grid
$("#chkISP").change(function (e) {

    e = e || window.event;
    var targetEle = e.target,
        treeObj = $("#TreeGrid").data("ejTreeGrid"),
        checkStatus = $(targetEle).is(':checked');
    if (checkStatus == false) {
        treeObj.hideColumn("ISP"); //passing the header text to hide the column 
    }
    else {
        treeObj.showColumn("ISP"); //passing the header text to show the column 
    }

});

$("#chkColModality").change(function (e) {

    e = e || window.event;
    var targetEle = e.target,
        treeObj = $("#TreeGrid").data("ejTreeGrid"),
        checkStatus = $(targetEle).is(':checked');
    if (checkStatus == false) {
        treeObj.hideColumn("Modality"); //passing the header text to hide the column 
    }
    else {
        treeObj.showColumn("Modality"); //passing the header text to show the column 
    }

});

$("#chkColVendor").change(function (e) {

    e = e || window.event;
    var targetEle = e.target,
        treeObj = $("#TreeGrid").data("ejTreeGrid"),
        checkStatus = $(targetEle).is(':checked');
    if (checkStatus == false) {
        treeObj.hideColumn("Vendor"); //passing the header text to hide the column 
    }
    else {
        treeObj.showColumn("Vendor"); //passing the header text to show the column 
    }

});

$("#chkColModel").change(function (e) {

    e = e || window.event;
    var targetEle = e.target,
        treeObj = $("#TreeGrid").data("ejTreeGrid"),
        checkStatus = $(targetEle).is(':checked');
    if (checkStatus == false) {
        treeObj.hideColumn("Model"); //passing the header text to hide the column 
    }
    else {
        treeObj.showColumn("Model"); //passing the header text to show the column 
    }

});

$("#chkColSoftware").change(function (e) {

    e = e || window.event;
    var targetEle = e.target,
        treeObj = $("#TreeGrid").data("ejTreeGrid"),
        checkStatus = $(targetEle).is(':checked');
    if (checkStatus == false) {
        treeObj.hideColumn("Software"); //passing the header text to hide the column 
    }
    else {
        treeObj.showColumn("Software"); //passing the header text to show the column 
    }

});


$("#chkColDomain").change(function (e) {

    e = e || window.event;
    var targetEle = e.target,
        treeObj = $("#TreeGrid").data("ejTreeGrid"),
        checkStatus = $(targetEle).is(':checked');
    if (checkStatus == false) {
        treeObj.hideColumn("Domain"); //passing the header text to hide the column 
    }
    else {
        treeObj.showColumn("Domain"); //passing the header text to show the column 
    }

});

$("#chkColModule").change(function (e) {

    e = e || window.event;
    var targetEle = e.target,
        treeObj = $("#TreeGrid").data("ejTreeGrid"),
        checkStatus = $(targetEle).is(':checked');
    if (checkStatus == false) {
        treeObj.hideColumn("Module"); //passing the header text to hide the column 
    }
    else {
        treeObj.showColumn("Module"); //passing the header text to show the column 
    }

});



$("#chkColDefinition").change(function (e) {

    e = e || window.event;
    var targetEle = e.target,
        treeObj = $("#TreeGrid").data("ejTreeGrid"),
        checkStatus = $(targetEle).is(':checked');
    if (checkStatus == false) {
        treeObj.hideColumn("Data Set Definition"); //passing the header text to hide the column 
    }
    else {
        treeObj.showColumn("Data Set Definition"); //passing the header text to show the column 
    }

});



//chkmoved


$(document).on('show', '.accordion', function (e) {
    //$('.accordion-heading i').toggleClass(' ');
    $(e.target).prev('.accordion-heading').addClass('accordion-opened');
});

$(document).on('hide', '.accordion', function (e) {
    $(this).find('.accordion-heading').not($(e.target)).removeClass('accordion-opened');
    //$('.accordion-heading i').toggleClass('fa-chevron-right fa-chevron-down');
});



$('.close').on('click', function (e) {
    $('.footer-fixed').toggleClass("close-footer");
});



$('.multi-vendor-title').on('click', function (e) {
    $('.agree-btn').toggleClass("visible-btn");
});


(function ($) {
    $(window).on("load", function () {

        $("a[rel='load-content']").click(function (e) {
            e.preventDefault();
            var url = $(this).attr("href");
            $.get(url, function (data) {
                $(".content .mCSB_container").append(data); //load new content inside .mCSB_container
                //scroll-to appended content 
                $(".content").mCustomScrollbar("scrollTo", "h2:last");
            });
        });

        $(".content").delegate("a[href='top']", "click", function (e) {
            e.preventDefault();
            $(".content").mCustomScrollbar("scrollTo", $(this).attr("href"));
        });

    });
})(jQuery);





hide = true;
$('body').on("click", function () {
    if (hide) $('.top-header .navbar-inverse .navbar-nav li').removeClass('active');
    hide = true;
});

// add and remove .active
$('body').on('click', '.top-header .navbar-inverse .navbar-nav li', function () {

    var self = $(this);

    if (self.hasClass('active')) {
        $('.top-header .navbar-inverse .navbar-nav li').removeClass('active');
        return false;
    }

    $('.top-header .navbar-inverse .navbar-nav li').removeClass('active');

    self.toggleClass('active');
    hide = false;
});

