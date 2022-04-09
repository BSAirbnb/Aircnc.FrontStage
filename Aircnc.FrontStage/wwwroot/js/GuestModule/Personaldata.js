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
//const btn_edit_gender = document.querySelector('#btn_edit_gender')
//const show_gender = document.querySelector('#show_gender')
//const select_gender = document.querySelector('#select_gender')
//const btn_save_gender = document.querySelector('#btn_save_gender')
//btn_edit_gender.addEventListener('click', () => {

//    select_gender.value = show_gender.innerText
//})
//btn_save_gender.addEventListener('click', () => {
//    show_gender.innerText = select_gender.value
//    let result = {}
//    result.Gender = show_gender.value

//    fetch('/Personal/PostChangeGender', {
//        method: "POST",
//        headers: {
//            "Content-Type": "application/json"
//        },
//        body: JSON.stringify(result)
//    }).then(response => response.json())
//})

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

// 
const add_btn = document.querySelector('#add_btn')
const todo_input = document.querySelector('.todo_input')
const todoWrap = document.querySelector('.todo_wrap')
const output = document.querySelector('.output')
let todolist = [] //先在全域宣告一個空的todolist 便於從localstorage裡面取資料放進來

add_btn.addEventListener('click', addtodo) //按下去後, 即啟動addtodo這個function

window.onload = function () {
    load_to_do_list() //每次載入網頁時, 同時啟動localstorage
}
function addtodo(event) {
    let todoobj = { title: todo_input.value }
    //宣告一個物件內容為 : title就是我輸入的事項, checked:false為不打勾
    if (todolist == null) todolist = []
    todolist.push(todoobj)
    localStorage.setItem("datalist", JSON.stringify(todolist))
    load_to_do_list()
}

function addtodolist(d, i) //d = data, i = index
{
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
    localStorage.setItem("datalist", JSON.stringify(todolist)) //update最新資料onto localStorage
    load_to_do_list()
}

function load_to_do_list() {
    todolist = JSON.parse(localStorage.getItem('datalist'))
    console.log(todolist);
    todoWrap.innerHTML = ""
    if (todolist != null)        //給todolist一個空值, 如果todolist不是空值, 將資料逐筆迭代出來然後裝進addtodolist
    {
        todolist.forEach((data, index) => {
            addtodolist(data, index)
        })
    }
    console.log(addtodolist)
}