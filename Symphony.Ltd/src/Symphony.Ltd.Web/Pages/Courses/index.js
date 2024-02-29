$(function () {
    var l = abp.localization.getResource("Ltd");
	
	var courseService = window.symphony.ltd.courses.courses;
	
	
    var createModal = new abp.ModalManager({
        viewUrl: abp.appPath + "Courses/CreateModal",
        scriptUrl: abp.appPath + "Pages/Courses/createModal.js",
        modalClass: "courseCreate"
    });

	var editModal = new abp.ModalManager({
        viewUrl: abp.appPath + "Courses/EditModal",
        scriptUrl: abp.appPath + "Pages/Courses/editModal.js",
        modalClass: "courseEdit"
    });

	var getFilter = function() {
        return {
            filterText: $("#FilterText").val(),
            title: $("#TitleFilter").val(),
			description: $("#DescriptionFilter").val(),
			teacherId: $("#TeacherIdFilter").val(),
			price: $("#PriceFilter").val(),
			topicId: $("#TopicIdFilter").val(),
			learnTime: $("#LearnTimeFilter").val()
        };
    };
    
    
    
    var dataTableColumns = [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l("Edit"),
                                visible: abp.auth.isGranted('Ltd.Courses.Edit'),
                                action: function (data) {
                                    editModal.open({
                                     id: data.record.id
                                     });
                                }
                            },
                            {
                                text: l("Delete"),
                                visible: abp.auth.isGranted('Ltd.Courses.Delete'),
                                confirmMessage: function () {
                                    return l("DeleteConfirmationMessage");
                                },
                                action: function (data) {
                                    courseService.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l("SuccessfullyDeleted"));
                                            dataTable.ajax.reloadEx();;
                                        });
                                }
                            }
                        ]
                },
                width: "1rem"
            },
			{ data: "title" },
			{ data: "description" },
			{ data: "teacherId" },
			{ data: "price" },
			{ data: "topicId" },
			{ data: "learnTime" }        
    ];
    
    

    var dataTable = $("#CoursesTable").DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        scrollX: true,
        autoWidth: true,
        scrollCollapse: true,
        order: [[1, "asc"]],
        ajax: abp.libs.datatables.createAjax(courseService.getList, getFilter),
        columnDefs: dataTableColumns
    }));
    
    

    createModal.onResult(function () {
        dataTable.ajax.reloadEx();;
    });

    editModal.onResult(function () {
        dataTable.ajax.reloadEx();;
    });

    $("#NewCourseButton").click(function (e) {
        e.preventDefault();
        createModal.open();
    });

	$("#SearchForm").submit(function (e) {
        e.preventDefault();
        dataTable.ajax.reloadEx();;
    });

    $('#AdvancedFilterSectionToggler').on('click', function (e) {
        $('#AdvancedFilterSection').toggle();
    });

    $('#AdvancedFilterSection').on('keypress', function (e) {
        if (e.which === 13) {
            dataTable.ajax.reloadEx();;
        }
    });

    $('#AdvancedFilterSection select').change(function() {
        dataTable.ajax.reloadEx();;
    });
    
    
    
    
    
    
    
    
});
