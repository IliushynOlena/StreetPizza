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