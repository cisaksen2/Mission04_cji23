$('#btnSend').click(function () { //function called
    var assignments = $("#assignments").val(); //initiating variables and setting them equal to form values
    var group = $("#group").val();
    var quizzes = $("#quizzes").val();
    var midterm = $("#midterm").val();
    var final = $("#final").val();
    var intex = $("#intex").val();

    //calculating final num grades
    var finalNumGrade = ((assignments * .5) + (group * .1) + (quizzes * .1) + (midterm * .1) + (final * .1) + (intex * .1)) / (1);
    finalNumGrade = Math.round(finalNumGrade)

    //if/else if logic nesting to determine final letter grade
    if (finalNumGrade >= 94) {
        finalLetterGrade = "A";
    } else if (finalNumGrade >= 90) {
        finalLetterGrade = "A-";
    } else if (finalNumGrade >= 87) {
        finalLetterGrade = "B+";
    } else if (finalNumGrade >= 84) {
        finalLetterGrade = "B";
    } else if (finalNumGrade >= 80) {
        finalLetterGrade = "B-";
    } else if (finalNumGrade >= 77) {
        finalLetterGrade = "C+";
    } else if (finalNumGrade >= 74) {
        finalLetterGrade = "C";
    } else if (finalNumGrade >= 70) {
        finalLetterGrade = "C-";
    } else if (finalNumGrade >= 67) {
        finalLetterGrade = "D+";
    } else if (finalNumGrade >= 64) {
        finalLetterGrade = "D";
    } else if (finalNumGrade >= 60) {
        finalLetterGrade = "D-";
    } else {
        finalLetterGrade = "E";
    }

    //variables for numeric and letter final display
    var percentFinalDisplay = "Numeric Grade: " + finalNumGrade
    var letterFinalDisplay = "Letter Grade: " + finalLetterGrade

    //attaching final displays to form labels using jquery
    $("#percentFinalDisplay").text(percentFinalDisplay);
    $("#letterFinalDisplay").text(letterFinalDisplay);
})