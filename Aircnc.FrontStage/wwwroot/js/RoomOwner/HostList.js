// let btn_edit_room_minus = document.querySelectorAll('.btn_edit_room_minus');
// let btn_edit_room_plus = document.querySelectorAll('.btn_edit_room_plus');
let edit_room_count = document.querySelector('.edit_room_count');
let edit_bed_count = document.querySelector('.edit_bed_count');
let edit_bathroom_count = document.querySelector('.edit_bathroom_count');

let form_check_equipment_and_service = document.querySelectorAll(
  '.form_check_equipment_and_service>input'
);

let form_check_roomStatus = document.querySelectorAll(
  '.form_check_roomStatus>input'
);

// 減
function room_minus(minusBtn) {
  var count = document.querySelector('.' + minusBtn);
  if (count.textContent > 0) {
    count.textContent -= 1;
  }
}

// 加
function room_plus(plusBtn) {
  var count = document.querySelector('.' + plusBtn);
  count.textContent = parseInt(count.textContent) + 1;
}

// 清除
function edit_clear(clearType) {
  switch (clearType) {
    case 'clear_room':
      edit_room_count.innerHTML = 0;
      edit_bed_count.innerHTML = 0;
      edit_bathroom_count.innerHTML = 0;
      break;
    case 'clear_equipment_and_service':
      form_check_equipment_and_service.forEach((item) =>
        item.removeAttribute('checked')
      );
      break;
    case 'clear_roomStatus':
      form_check_roomStatus.forEach((item) => item.removeAttribute('checked'));
      break;
    default:
      break;
  }
}
