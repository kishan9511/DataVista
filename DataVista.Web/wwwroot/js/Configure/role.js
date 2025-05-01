import { handleDeleteBtnClick } from "../common.js";

$(function () {

    loadDataTable();
    handleDeleteBtnClick("/Configuration/DeleteRole?id=", dataTable);
});

function loadDataTable() {
    dataTable = $("#datatable").DataTable({
        ajax: {
            url: "/Configuration/GetAllRole"
        },
        columns: [
            //{
            //    "data": "id",
            //    width: "20%",
            //    "render": function (mData, type, row, meta) {
            //        return meta.row + meta.settings._iDisplayStart + 1;
            //    }
            //},
            { data: "id" },
            { data: "name" },
            {
                data: "id",
                width: "25%",
                render: function (data) {
                    return `
                    <div>
                        <a href="/Configuration/Role?id=${data}" class="btn btn-soft-info mx-2 fs-5">
                            <i class="bx bx-edit"></i>
                        </a>
                        <a   class="btn btn-soft-danger mx-2 fs-5 delete-btn" data-delete-id="${data}">
                            <i class="bx bxs-trash"></i>
                        </a>
                        </div>`;
                }
            },
        ],
    });
}