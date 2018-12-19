var LoanSubmissionViewModel = function (obj, fileEl) {
    var self = this;
    obj = obj || {
        LoanProductOptions: null,
        LoanRateOptions: null,
        DocFileId: null,
        BorrowerCreditScore: null,
        CuScore: null,
        LcaScore: null,
        Dti: null,
        Ltv: null,
        CraLoan: null,
        InterestRate: null,
        LoanAmount: null,
        FilesToUpload: null
    };
    self.formData = new FormData();
    self.PropertyStreetName = ko.observable('');
    self.PropertyCity = ko.observable('');
    self.PropertyState = ko.observable('');
    self.PropertyZip = ko.observable('');
    self.LoanProductOptions = ko.observableArray(obj.loanProductOptions);
    self.LoanProduct = ko.observable('');
    self.LoanRateOptions = ko.observableArray(obj.loanRateOptions);
    self.LoanRate = ko.observable('');
    self.BorrowerCreditScore = ko.observable('');
    self.CuScore = ko.observable('');
    self.LcaScore = ko.observable('');
    self.Dti = ko.observable('');
    self.Ltv = ko.observable('');
    self.CraLoanOptions = ko.observableArray(obj.craLoanOptions);
    self.CraLoan = ko.observableArray('');
    self.InterestRate = ko.observable('');
    self.LoanAmount = ko.observable('');
    self.FilesToUpload = ko.observableArray();
    self.fileEl = fileEl;
    self.IsFileReady = ko.observable(false);

    self.addFile = function () {
        // change this to allow multiple files
        self.formData.append("", self.fileEl[0].files[0]);
        //self.CoverLetterFileName(self.fileEl[0].files[0].name);
        var currentFile = '<span class="fa fa-file-text-o text-dark-gray"></span>&ensp;<strong>' + self.fileEl[0].files[0].name + '</strong>&ensp;' + Math.ceil(fileInput.files[0].size / 1000) + '<small>kb</small>'
        var fileName = self.fileEl[0].files[0].name;
        jQuery('#fileFormControl').append(currentFile);
        //var fileNameContents = fileName.split('.');
        //self.FilesToUpload.push({ name: fileName });
        //self.IsFileReady(true);
        //console.log(self.FilesToUpload());
        //debugger;
    };


    self.submitSettings = function (data) {
        var modelData = JSON.stringify({
            LoanProduct: self.LoanProduct(),
            LoanRate: self.LoanRate(),
            DocFileId: self.DocFileId(),
            BorrowerCreditScore: self.BorrowerCreditScore(),
            CuScore: self.CuScore(),
            LcaScore: self.LcaScore(),
            Dti: self.Dti(),
            Ltv: self.Ltv(),
            CraLoan: self.CraLoan(),
            InterestRate: self.InterestRate(),
            LoanAmount: self.LoanAmount(),
        });
        var formData = new FormData();
        formData.append("model", modelData);
        //var files = self.FilesToUpload();
        //if (self.fileEl[0].files.length > 0)
        //    formData.append("coverPdf", self.fileEl[0].files[0]);

        $.ajax('SubmitSettings', {
            //enctype: 'multipart/form-data',
            contentType: false,
            type: 'POST',
            data: formData,
            processData: false,
            beforeSend: function () {
                var formIsValid = true;

                if (!formIsValid) {
                    alert('what are you doing?!');
                    return false;
                }

                //if (self.fileEl[0].files.length > 0) {
                //    // Now, check filetype
                //    var fileTypeErrorMsg = 'Invalid file type uploaded.<br />Only a .pdf file extension is allowed.';

                //    // arr parameter is broken in IE9 and under. Get filename directly from input element
                //    var fileName = $('input[type=file]').val().split('\\').pop();

                //    if (typeof fileName === "undefined" || fileName === null) {
                //        toastr.error(fileTypeErrorMsg);
                //        return false;
                //    }

                //    var parts = fileName.split('.');
                //    var ext = parts.pop();

                //    if (ext.toUpperCase() !== "PDF") {
                //        toastr.error(fileTypeErrorMsg);
                //        $.unblockUI();
                //        return false;
                //    }
                //}
                return true;
            },
            success: function (data) {
                alert('woohoo!');

            },
            error: function (data) {
                alert('whoa now...something is...wrong?');
            }
        });

    }
 }