document.addEventListener("DOMContentLoaded", function () {
    const searchInput = document.getElementById("searchInput");
    const selectedColumn = document.getElementById("selectedColumn");
    const dropdownItems = document.querySelectorAll(".dropdown-item");

    let columnIndex = null;

    const dropdownMenu = document.getElementById("dropdownMenuButton");
    dropdownMenu.addEventListener("click", function () {
        selectedColumn.innerText = "Søk i: Alle kolonner";
        searchInput.value = "";
        columnIndex = null; // Sett columnIndex til null når du velger "Alle kolonner"
        søkTable();
    });

    dropdownItems.forEach((item) => {
        item.addEventListener("click", function () {
            columnIndex = item.dataset.columnIndex;
            const columnName = item.innerText;
            selectedColumn.innerText = "Søk i: " + columnName;
            søkTable();
            filterTable(searchInput.value.toLowerCase(), columnIndex);
        });
    });

    searchInput.addEventListener("input", function () {
        const searchTerm = searchInput.value.toLowerCase();
        const selectedColumnName = selectedColumn.innerText.replace("Søk i: ", "");

        søkTable();
        filterTable(searchTerm, columnIndex);
    });

    function søkTable() {
        const tableRows = document.querySelectorAll("tbody tr");
        tableRows.forEach((row) => {
            row.style.display = "";
            row.querySelectorAll("td").forEach((cell) => {
                if (!cell.hasAttribute("data-original-html")) {
                    cell.setAttribute("data-original-html", cell.innerHTML);
                }
                cell.innerHTML = cell.getAttribute("data-original-html");
            });
        });
    }

    function filterTable(searchTerm, columnIndex) {
        const tableRows = document.querySelectorAll("tbody tr");
        tableRows.forEach((row) => {
            let hasMatch = false;
            row.querySelectorAll("td").forEach((cell, index) => {
                const cellText = cell.textContent.toLowerCase();
                if (
                    (columnIndex === null || index == columnIndex) &&
                    cellText.includes(searchTerm)
                ) {
                    hasMatch = true;
                    const highlightedText = cellText.replace(new RegExp(searchTerm, "gi"), (match) => {
                        return `<span class="highlight">${match}</span>`;
                    });
                    cell.innerHTML = highlightedText;
                } else {
                    cell.innerHTML = cellText;
                }
            });
            row.style.display = hasMatch ? "" : "none";
        });
    }
});
