$(function() {
    $('.datePicker').datetimepicker({ format: 'DD/MM/YYYY'});
    $('.datePicker2').datetimepicker({
        format: 'DD/MM/YYYY',
        useCurrent: false //Important! See issue #1075
    });
    $(".datePicker").on("dp.change", function (e) {
        $('.datePicker2').data("DateTimePicker").minDate(e.date);
    });
    $(".datePicker2").on("dp.change", function (e) {
        $('.datePicker').data("DateTimePicker").maxDate(e.date);
    });
})