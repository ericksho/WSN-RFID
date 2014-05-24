class AddVehiculoIdToArticulos < ActiveRecord::Migration
  def change
    add_column :articulos, :vehiculo_id, :integer
  end
end
