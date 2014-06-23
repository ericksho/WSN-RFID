class ArticuloExtraInfo < ActiveRecord::Migration
  def change
		add_column :articulos, :upr, :string
	end
end
