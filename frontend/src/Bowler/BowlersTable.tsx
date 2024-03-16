import { useEffect, useState } from 'react';
import { Bowler } from '../types/Bowler';

function BowlersTable() {
  const [bowlerData, setbowlerData] = useState<Bowler[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      try {
        const rsp = await fetch('http://localhost:5236/Bowlers');
        if (!rsp.ok) {
          throw new Error('Failed to fetch data');
        }
        const data = await rsp.json();
        setbowlerData(data);
      } catch (error) {
        console.error('Error fetching data:', error);
      }
    };

    fetchBowlerData();
  }, []);

  return (
    <>
      <div>
        <h4>Bowler List</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Bowler Name</th>
            <th>Team ID</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {bowlerData.map((f) => (
            <tr key={f.bowlerId}>
              <td>
                {f.bowlerFirstName}, {f.bowlerMiddleInit}, {f.bowlerLastName}
              </td>
              <td>{f.teamId === 1 ? 'Marlins' : 'Sharks'}</td>
              <td>{f.bowlerAddress}</td>
              <td>{f.bowlerCity}</td>
              <td>{f.bowlerState}</td>
              <td>{f.bowlerZip}</td>
              <td>{f.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlersTable;
