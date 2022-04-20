////let btn_edit_room_minus = document.querySelector(".btn_edit_room_minus");
//let btn_edit_room_plus = document.querySelector(".btn_edit_room_plus");
let edit_room_guestCount = document.querySelector(".edit_room_guestCount");

function btn_edit_room_minus() {
    if (edit_room_guestCount.textContent > 0) {
        edit_room_guestCount = parseInt(edit_room_guestCount.textContent) - 1;
    }
}

function btn_edit_room_plus() {
    edit_room_guestCount = parseInt(edit_room_guestCount.textContent) + 1;
}