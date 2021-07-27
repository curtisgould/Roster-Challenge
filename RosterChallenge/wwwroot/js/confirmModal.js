function closeConfirmModal() {
    $("#confirmModal.modal").hide();
    $("#confirmBackdrop.modal-backdrop").hide();
}

function openConfirmModal(title, message, yesFunc, noFunc) {
    $("#confirmModal .modal-header").text(title);
    $("#confirmModal .modal-body").text(message);
    $("#confirmModal.modal").show();
    $("#confirmBackdrop.modal-backdrop").show();

    if (typeof yesFunc !== 'function') {
        yesFunc = function () { };
    }

    if (typeof noFunc !== 'function') {
        noFunc = function () { };
    }

    $("#ConfirmYesButton").off();
    $("#ConfirmYesButton").on("click", function () { yesFunc(); closeConfirmModal(); });

    $("#ConfirmNoButton").off();
    $("#ConfirmNoButton").on("click", function () { noFunc(); closeConfirmModal(); });
}