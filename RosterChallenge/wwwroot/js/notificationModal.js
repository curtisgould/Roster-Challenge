function closeNotificationModal() {
    $("#NotificationModal.modal").hide();
    $("#NotificationBackdrop.modal-backdrop").hide();
}

function openNotificationModal(title, message, OKFunc) {
    $("#NotificationModal .modal-header").text(title);
    $("#NotificationModal .modal-body").text(message);
    $("#NotificationModal.modal").show();
    $("#NotificationBackdrop.modal-backdrop").show();

    if (typeof OKFunc !== 'function') {
        OKFunc = function () { };
    }

    $("#NotificationOKButton").off();
    $("#NotificationOKButton").on("click", function () { OKFunc(); closeNotificationModal(); });
}