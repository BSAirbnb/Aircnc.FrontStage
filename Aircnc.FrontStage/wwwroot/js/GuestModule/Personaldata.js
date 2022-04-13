////document.querySelector('.edit-btn').addEventListener("click", () => {
////    document.querySelector('.edit-btn').innerText = "取消";
////    document.querySelector('.edit-btn').addEventListener("click", () => {
////        document.querySelector('.edit-btn').innerText = "編輯";
////    })
////});


// 修改名字
const btn_edit_name = document.querySelector('#btn_edit_name')
const show_name = document.querySelector('#show_name')
const input_name = document.querySelector('#input_name')
const btn_save_name = document.querySelector('#btn_save_name')
btn_edit_name.addEventListener('click', () => {

    input_name.value = show_name.innerText
})

btn_save_name.addEventListener('click', () => {

    show_name.innerText = input_name.value
    let result = {}
    result.Name = show_name.innerText

    fetch('/Personal/PostChangeName', {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(result)
    }).then(response => response.json())
})

// 修改性別
const btn_edit_gender = document.querySelector('#btn_edit_gender')
const show_gender = document.querySelector('#show_gender')
const select_gender = document.querySelector('#select_gender')
const btn_save_gender = document.querySelector('#btn_save_gender')
btn_save_gender.addEventListener('click', () => {
    show_gender.innerText = select_gender.options[select_gender.selectedIndex].text;
    let result = {}
    result.Gender = select_gender.options[select_gender.selectedIndex].value

    fetch('/Personal/PostChangeGender', {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(result)
    }).then(response => response.json())
})

// 修改生日
const btn_edit_birthday = document.querySelector('#btn_edit_birthday')
const show_birthday = document.querySelector('#show_birthday')
const input_birthday = document.querySelector('#input_birthday')
const btn_save_birthday = document.querySelector('#btn_save_birthday')
btn_edit_birthday.addEventListener('click', () => {

    input_birthday.value = show_birthday.innerText
})

btn_save_birthday.addEventListener('click', () => {

    show_birthday.innerText = input_birthday.value
    let result = {}
    result.Birthday = show_birthday.innerText

    fetch('/Personal/PostChangeBirthday', {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(result)
    }).then(response => response.json())
})

// 修改email
const btn_edit_email = document.querySelector('#btn_edit_email')
const span_email = document.querySelector('#span_email')
const show_email = document.querySelector('#show_email')
const btn_save_email = document.querySelector('#btn_save_email')
btn_edit_email.addEventListener('click', () => {

    show_email.value = span_email.innerText
})
btn_save_email.addEventListener('click', () => {
    span_email.innerText = show_email.value
    let result = {}
    result.Email = span_email.innerText

    fetch('/Personal/PostChangeEmail', {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(result)
    }).then(response => response.json())
})

// 修改電話
const btn_edit_phone = document.querySelector('#btn_edit_phone')
const show_phone = document.querySelector('#show_phone')
const input_phone = document.querySelector('#input_phone')
const btn_save_phone = document.querySelector('#btn_save_phone')
btn_edit_phone.addEventListener('click', () => {

    input_phone.value = show_phone.innerText
})
btn_save_phone.addEventListener('click', () => {
    show_phone.innerText = input_phone.value
    let result = {}
    result.Phone = show_phone.innerText

    fetch('/Personal/PostChangePhone', {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(result)
    }).then(response => response.json())
})

// 中國旅遊的護照資訊
const add_btn = document.querySelector('#add_btn')
const todo_input = document.querySelector('.todo_input')
const todoWrap = document.querySelector('.todo_wrap')
const output = document.querySelector('.output')
let todolist = []

add_btn.addEventListener('click', addtodo)

window.onload = function () {
    load_to_do_list()
}
function addtodo(event) {
    let todoobj = { title: todo_input.value }
    if (todolist == null) todolist = []
    todolist.push(todoobj)
    localStorage.setItem("datalist", JSON.stringify(todolist))
    load_to_do_list()
}

function addtodolist(d, i) {
    const todo_wrap = document.createElement('div')
    todo_wrap.classList.add('todo_wrap', 'd-flex', 'flex-row', 'align-items-center')
    const todo_div = document.createElement('div')
    todo_div.classList.add('todo_div', 'input-group', 'mb-3')

    const show_input = document.createElement('input')
    show_input.classList.add('form-control', 'show_input', 'bg-white', 'text-dark', 'border-white')
    show_input.type = 'text'
    show_input.setAttribute('style', 'font-size: 16px')
    show_input.setAttribute('style', 'padding: 0px')
    show_input.setAttribute('style', 'color: rgb(34, 34, 34')
    show_input.value = d.title
    show_input.disabled = true
    todo_div.append(show_input)

    const delete_btn = document.createElement('button')
    delete_btn.classList.add('btn', 'edit-btn')
    delete_btn.id = `delete_btn`
    delete_btn.type = 'button'
    delete_btn.innerText = '刪除'
    delete_btn.addEventListener('click', () => { delete_btnfn(i) })
    todo_div.append(delete_btn)
    todoWrap.append(todo_div)
}

function delete_btnfn(ii) {
    todolist.splice(ii, 1)
    console.log(todolist)
    localStorage.setItem("datalist", JSON.stringify(todolist))
    load_to_do_list()
}

function load_to_do_list() {
    todolist = JSON.parse(localStorage.getItem('datalist'))
    console.log(todolist);
    todoWrap.innerHTML = ""
    if (todolist != null) {
        todolist.forEach((data, index) => {
            addtodolist(data, index)
        })
    }
    console.log(addtodolist)
}