// показуємо/ховаємо панель видалення ролей
function toggleDeleteSpan(id, isShowed) {
    if (isShowed) {
        $(`#shortDeleteSpan_${id}`).hide();
        $(`#longDeleteSpan_${id}`).show();
    }
    else {
        $(`#shortDeleteSpan_${id}`).show();
        $(`#longDeleteSpan_${id}`).hide();
    }
};

$(".custom-file-input").on("change", function () {
    var fileName = $(this).val().split("\\").pop();
    $(this).siblings(".custom-file-label").addClass("selected").html(fileName);
});